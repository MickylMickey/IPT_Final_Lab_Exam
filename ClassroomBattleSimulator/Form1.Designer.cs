namespace ClassroomBattleSimulator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox comboBoxPlayer1;
        private System.Windows.Forms.ComboBox comboBoxPlayer2;
        private System.Windows.Forms.Panel panelPlayer1Skills;
        private System.Windows.Forms.Panel panelPlayer2Skills;
        private System.Windows.Forms.Button buttonStartBattle;
        private System.Windows.Forms.ListBox listBoxBattleLog;
        private System.Windows.Forms.ProgressBar progressBarPlayer1;
        private System.Windows.Forms.ProgressBar progressBarPlayer2;
        private System.Windows.Forms.Label labelTurn;
        private System.Windows.Forms.PictureBox pictureBoxAvatar1;
        private System.Windows.Forms.PictureBox pictureBoxAvatar2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxPlayer1 = new System.Windows.Forms.ComboBox();
            this.comboBoxPlayer2 = new System.Windows.Forms.ComboBox();
            this.panelPlayer1Skills = new System.Windows.Forms.Panel();
            this.panelPlayer2Skills = new System.Windows.Forms.Panel();
            this.buttonStartBattle = new System.Windows.Forms.Button();
            this.listBoxBattleLog = new System.Windows.Forms.ListBox();
            this.progressBarPlayer1 = new System.Windows.Forms.ProgressBar();
            this.progressBarPlayer2 = new System.Windows.Forms.ProgressBar();
            this.labelTurn = new System.Windows.Forms.Label();
            this.pictureBoxAvatar1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxAvatar2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPlayer1
            // 
            this.comboBoxPlayer1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlayer1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPlayer1.FormattingEnabled = true;
            this.comboBoxPlayer1.Location = new System.Drawing.Point(30, 20);
            this.comboBoxPlayer1.Name = "comboBoxPlayer1";
            this.comboBoxPlayer1.Size = new System.Drawing.Size(180, 23);
            this.comboBoxPlayer1.TabIndex = 0;
            // 
            // comboBoxPlayer2
            // 
            this.comboBoxPlayer2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlayer2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPlayer2.FormattingEnabled = true;
            this.comboBoxPlayer2.Location = new System.Drawing.Point(650, 20);
            this.comboBoxPlayer2.Name = "comboBoxPlayer2";
            this.comboBoxPlayer2.Size = new System.Drawing.Size(180, 23);
            this.comboBoxPlayer2.TabIndex = 1;
            // 
            // panelPlayer1Skills
            // 
            this.panelPlayer1Skills.BackColor = System.Drawing.Color.Transparent;
            this.panelPlayer1Skills.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPlayer1Skills.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelPlayer1Skills.Location = new System.Drawing.Point(30, 310);
            this.panelPlayer1Skills.Name = "panelPlayer1Skills";
            this.panelPlayer1Skills.Size = new System.Drawing.Size(180, 150);
            this.panelPlayer1Skills.TabIndex = 6;
            // 
            // panelPlayer2Skills
            // 
            this.panelPlayer2Skills.BackColor = System.Drawing.Color.Transparent;
            this.panelPlayer2Skills.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPlayer2Skills.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelPlayer2Skills.Location = new System.Drawing.Point(650, 310);
            this.panelPlayer2Skills.Name = "panelPlayer2Skills";
            this.panelPlayer2Skills.Size = new System.Drawing.Size(180, 150);
            this.panelPlayer2Skills.TabIndex = 7;
            // 
            // buttonStartBattle
            // 
            this.buttonStartBattle.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonStartBattle.Font = new System.Drawing.Font("Carnivalee Freakshow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartBattle.ForeColor = System.Drawing.Color.White;
            this.buttonStartBattle.Location = new System.Drawing.Point(316, 20);
            this.buttonStartBattle.Name = "buttonStartBattle";
            this.buttonStartBattle.Size = new System.Drawing.Size(241, 57);
            this.buttonStartBattle.TabIndex = 8;
            this.buttonStartBattle.Text = "Start Battle";
            this.buttonStartBattle.UseVisualStyleBackColor = false;
            this.buttonStartBattle.Click += new System.EventHandler(this.buttonStartBattle_Click_1);
            // 
            // listBoxBattleLog
            // 
            this.listBoxBattleLog.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxBattleLog.Font = new System.Drawing.Font("Courier New", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxBattleLog.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.listBoxBattleLog.FormattingEnabled = true;
            this.listBoxBattleLog.ItemHeight = 11;
            this.listBoxBattleLog.Location = new System.Drawing.Point(233, 142);
            this.listBoxBattleLog.Name = "listBoxBattleLog";
            this.listBoxBattleLog.Size = new System.Drawing.Size(400, 312);
            this.listBoxBattleLog.TabIndex = 10;
            this.listBoxBattleLog.SelectedIndexChanged += new System.EventHandler(this.listBoxBattleLog_SelectedIndexChanged);
            // 
            // progressBarPlayer1
            // 
            this.progressBarPlayer1.Location = new System.Drawing.Point(30, 270);
            this.progressBarPlayer1.Name = "progressBarPlayer1";
            this.progressBarPlayer1.Size = new System.Drawing.Size(180, 25);
            this.progressBarPlayer1.TabIndex = 4;
            // 
            // progressBarPlayer2
            // 
            this.progressBarPlayer2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.progressBarPlayer2.Location = new System.Drawing.Point(650, 270);
            this.progressBarPlayer2.Name = "progressBarPlayer2";
            this.progressBarPlayer2.Size = new System.Drawing.Size(180, 25);
            this.progressBarPlayer2.TabIndex = 5;
            // 
            // labelTurn
            // 
            this.labelTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelTurn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTurn.Font = new System.Drawing.Font("Carnivalee Freakshow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTurn.ForeColor = System.Drawing.Color.Transparent;
            this.labelTurn.Location = new System.Drawing.Point(233, 89);
            this.labelTurn.Name = "labelTurn";
            this.labelTurn.Size = new System.Drawing.Size(400, 40);
            this.labelTurn.TabIndex = 9;
            this.labelTurn.Text = "Turn: ";
            this.labelTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTurn.Click += new System.EventHandler(this.labelTurn_Click);
            // 
            // pictureBoxAvatar1
            // 
            this.pictureBoxAvatar1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAvatar1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxAvatar1.Location = new System.Drawing.Point(30, 60);
            this.pictureBoxAvatar1.Name = "pictureBoxAvatar1";
            this.pictureBoxAvatar1.Size = new System.Drawing.Size(180, 200);
            this.pictureBoxAvatar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar1.TabIndex = 2;
            this.pictureBoxAvatar1.TabStop = false;
            // 
            // pictureBoxAvatar2
            // 
            this.pictureBoxAvatar2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAvatar2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxAvatar2.Location = new System.Drawing.Point(650, 60);
            this.pictureBoxAvatar2.Name = "pictureBoxAvatar2";
            this.pictureBoxAvatar2.Size = new System.Drawing.Size(180, 200);
            this.pictureBoxAvatar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar2.TabIndex = 3;
            this.pictureBoxAvatar2.TabStop = false;
            // 
            // Form1
            // 
            this.BackgroundImage = global::ClassroomBattleSimulator.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(860, 480);
            this.Controls.Add(this.listBoxBattleLog);
            this.Controls.Add(this.labelTurn);
            this.Controls.Add(this.buttonStartBattle);
            this.Controls.Add(this.panelPlayer2Skills);
            this.Controls.Add(this.panelPlayer1Skills);
            this.Controls.Add(this.progressBarPlayer2);
            this.Controls.Add(this.progressBarPlayer1);
            this.Controls.Add(this.pictureBoxAvatar2);
            this.Controls.Add(this.pictureBoxAvatar1);
            this.Controls.Add(this.comboBoxPlayer2);
            this.Controls.Add(this.comboBoxPlayer1);
            this.Name = "Form1";
            this.Text = "Classroom Battle Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar2)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
