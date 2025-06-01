using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ClassroomBattleSimulator;

namespace ClassroomBattleSimulator
{
    public partial class Form1 : Form
    {
        private List<StudentHero> heroes;
        private BattleManager battleManager;
        private Timer animationTimer = new Timer();
        private PictureBox attackerPictureBox;
        private PictureBox targetPictureBox;
        private int animationStep = 0;
        private int animationMaxSteps = 10;
        private int animationDirection = 1;
        private int shakeStep = 0;
        private int maxShakeSteps = 6;
        private Point targetOriginalLocation;
        private Action animationCompletedCallback;

        public Form1()
        {
            InitializeComponent();
            heroes = StudentHero.GetAllHeroes();

            comboBoxPlayer1.DataSource = new List<string>(heroes.ConvertAll(h => h.Name));
            comboBoxPlayer2.DataSource = new List<string>(heroes.ConvertAll(h => h.Name));

            comboBoxPlayer1.SelectedIndexChanged += ComboBoxPlayer1_SelectedIndexChanged;
            comboBoxPlayer2.SelectedIndexChanged += ComboBoxPlayer2_SelectedIndexChanged;

            LoadAvatarFromResources(pictureBoxAvatar1, comboBoxPlayer1.SelectedItem.ToString());
            LoadAvatarFromResources(pictureBoxAvatar2, comboBoxPlayer2.SelectedItem.ToString());

            LoadPlayer1Skills();
            LoadPlayer2Skills();

            buttonStartBattle.Click += ButtonStartBattle_Click;
        }

        private void ComboBoxPlayer1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAvatarFromResources(pictureBoxAvatar1, comboBoxPlayer1.SelectedItem.ToString());
            LoadPlayer1Skills();
        }

        private void ComboBoxPlayer2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAvatarFromResources(pictureBoxAvatar2, comboBoxPlayer2.SelectedItem.ToString());
            LoadPlayer2Skills();
        }

        private void LoadAvatarFromResources(PictureBox pictureBox, string characterName)
        {
            string resourceKey = characterName.Replace(" ", "_");

            try
            {
                var image = (Image)Properties.Resources.ResourceManager.GetObject(resourceKey);

                if (image != null)
                {
                    if (pictureBox.Image != null)
                    {
                        ImageAnimator.StopAnimate(pictureBox.Image, OnFrameChanged);
                        pictureBox.Image.Dispose();
                        pictureBox.Image = null;
                    }

                    pictureBox.Image = image;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                    if (ImageAnimator.CanAnimate(image))
                    {
                        ImageAnimator.Animate(image, OnFrameChanged);
                    }
                }
                else
                {
                    MessageBox.Show($"Avatar not found in resources: {resourceKey}", "Missing Avatar");
                    pictureBox.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading avatar: {ex.Message}", "Avatar Error");
            }
        }

        private void OnFrameChanged(object sender, EventArgs e)
        {
            pictureBoxAvatar1?.Invalidate();
            pictureBoxAvatar2?.Invalidate();
        }

        private void LoadPlayer1Skills()
        {
            panelPlayer1Skills.Controls.Clear();
            var selectedHero = heroes[comboBoxPlayer1.SelectedIndex];
            for (int i = 0; i < selectedHero.Skills.Count; i++)
            {
                var skill = selectedHero.Skills[i];
                var btn = new Button
                {
                    Text = skill.Name,
                    Tag = i,
                    Width = 120,
                    Height = 30,
                    Location = new Point(5, i * 35 + 5)
                };
                btn.Click += Player1SkillButton_Click;
                panelPlayer1Skills.Controls.Add(btn);
            }
        }

        private void LoadPlayer2Skills()
        {
            panelPlayer2Skills.Controls.Clear();
            var selectedHero = heroes[comboBoxPlayer2.SelectedIndex];
            for (int i = 0; i < selectedHero.Skills.Count; i++)
            {
                var skill = selectedHero.Skills[i];
                var btn = new Button
                {
                    Text = skill.Name,
                    Tag = i,
                    Width = 120,
                    Height = 30,
                    Location = new Point(5, i * 35 + 5),
                    Enabled = false
                };
                btn.Click += Player2SkillButton_Click;
                panelPlayer2Skills.Controls.Add(btn);
            }
        }

        private void ButtonStartBattle_Click(object sender, EventArgs e)
        {
            listBoxBattleLog.Items.Clear();
            UpdateHealthBars();
            DisableAllSkillButtons();

            var hero1 = heroes[comboBoxPlayer1.SelectedIndex];
            var hero2 = heroes[comboBoxPlayer2.SelectedIndex];

            var player1 = new Character(hero1.Name, hero1.MaxHealth, hero1.Skills);
            var player2 = new Character(hero2.Name, hero2.MaxHealth, hero2.Skills);

            battleManager = new BattleManager(player1, player2);

            labelTurn.Text = $"{battleManager.CurrentPlayer.Name}'s turn";
            UpdateHealthBars();
            EnableCurrentPlayerSkills();

            buttonStartBattle.Enabled = false;
            comboBoxPlayer1.Enabled = false;
            comboBoxPlayer2.Enabled = false;
        }

        private void Player1SkillButton_Click(object sender, EventArgs e)
        {
            if (battleManager.CurrentPlayer.Name != heroes[comboBoxPlayer1.SelectedIndex].Name)
            {
                MessageBox.Show("It's not Player 1's turn!");
                return;
            }

            var btn = (Button)sender;
            int skillIndex = (int)btn.Tag;
            PerformTurn(skillIndex);
        }

        private void Player2SkillButton_Click(object sender, EventArgs e)
        {
            if (battleManager.CurrentPlayer.Name != heroes[comboBoxPlayer2.SelectedIndex].Name)
            {
                MessageBox.Show("It's not Player 2's turn!");
                return;
            }

            var btn = (Button)sender;
            int skillIndex = (int)btn.Tag;
            PerformTurn(skillIndex);
        }

        private void PerformTurn(int skillIndex)
        {
            var currentPlayer = battleManager.CurrentPlayer;
            var currentSkills = currentPlayer.Skills;

            if (skillIndex < 0 || skillIndex >= currentSkills.Count)
            {
                MessageBox.Show("Invalid skill selected!");
                return;
            }

            bool isPlayer1Turn = currentPlayer.Name == heroes[comboBoxPlayer1.SelectedIndex].Name;

            attackerPictureBox = isPlayer1Turn ? pictureBoxAvatar1 : pictureBoxAvatar2;
            targetPictureBox = isPlayer1Turn ? pictureBoxAvatar2 : pictureBoxAvatar1;

            DisableAllSkillButtons();

            animationStep = 0;
            animationDirection = 1;
            animationTimer.Interval = 30;
            animationTimer.Tick -= AnimationTimer_Tick;
            animationTimer.Tick += AnimationTimer_Tick;

            targetOriginalLocation = targetPictureBox.Location;

            animationCompletedCallback = () =>
            {
                var result = battleManager.ExecuteTurn(skillIndex);
                listBoxBattleLog.Items.Insert(0, result);
                UpdateHealthBars();

                if (battleManager.IsGameOver)
                {
                    var winner = battleManager.GetWinner();
                    labelTurn.Text = winner != null ? $"{winner.Name} wins!" : "It's a tie!";
                    DisableAllSkillButtons();
                }
                else
                {
                    labelTurn.Text = $"{battleManager.CurrentPlayer.Name}'s turn";
                    EnableCurrentPlayerSkills();
                }
            };

            animationTimer.Start();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            int movePixels = 5;

            if (animationStep < animationMaxSteps)
            {
                attackerPictureBox.Left += animationDirection * movePixels;
                animationStep++;
            }
            else if (animationDirection == 1)
            {
                animationDirection = -1;
                animationStep = 0;
            }
            else
            {
                animationTimer.Stop();
                shakeStep = 0;
                animationTimer.Tick -= AnimationTimer_Tick;
                animationTimer.Tick += ShakeTimer_Tick;
                animationTimer.Interval = 50;
                animationTimer.Start();
            }
        }

        private void ShakeTimer_Tick(object sender, EventArgs e)
        {
            int shakeOffset = 5;

            if (shakeStep < maxShakeSteps)
            {
                int offsetX = (shakeStep % 2 == 0) ? shakeOffset : -shakeOffset;
                targetPictureBox.Left = targetOriginalLocation.X + offsetX;
                shakeStep++;
            }
            else
            {
                animationTimer.Stop();
                targetPictureBox.Location = targetOriginalLocation;
                animationTimer.Tick -= ShakeTimer_Tick;

                animationCompletedCallback?.Invoke();
            }
        }

        private void UpdateHealthBars()
        {
            if (battleManager == null) return;

            progressBarPlayer1.Maximum = battleManager.player1.MaxHealth;
            progressBarPlayer2.Maximum = battleManager.player2.MaxHealth;

            progressBarPlayer1.Value = Math.Max(0, Math.Min(progressBarPlayer1.Maximum, battleManager.player1.Health));
            progressBarPlayer2.Value = Math.Max(0, Math.Min(progressBarPlayer2.Maximum, battleManager.player2.Health));
        }

        private void EnableCurrentPlayerSkills()
        {
            bool isPlayer1Turn = battleManager.CurrentPlayer.Name == heroes[comboBoxPlayer1.SelectedIndex].Name;

            foreach (Button btn in panelPlayer1Skills.Controls)
                btn.Enabled = isPlayer1Turn;

            foreach (Button btn in panelPlayer2Skills.Controls)
                btn.Enabled = !isPlayer1Turn;
        }

        private void DisableAllSkillButtons()
        {
            foreach (Button btn in panelPlayer1Skills.Controls)
                btn.Enabled = false;

            foreach (Button btn in panelPlayer2Skills.Controls)
                btn.Enabled = false;
        }
    }
}
