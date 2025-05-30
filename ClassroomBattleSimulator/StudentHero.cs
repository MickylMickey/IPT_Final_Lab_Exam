using System.Windows.Forms.VisualStyles;
using System.Collections.Generic;

namespace ClassroomBattleSimulator
{
    public class StudentHero
    {
        public string Name { get; set; }
        public int MaxHealth { get; set; }
        public List<Skill> Skills { get; set; }

        public StudentHero(string name, int maxHealth, List<Skill> skills)
        {
            Name = name;
            MaxHealth = maxHealth;
            Skills = skills;
        }

        // Factory method to get predefined heroes
        public static List<StudentHero> GetAllHeroes()
        {
            return new List<StudentHero>
            {
                new StudentHero("Math Wizard", 100, new List<Skill>
                {
                    new Skill("Calculate Strike", 20),
                    new Skill("Heal", 15, isHealing: true),
                    new Skill("Logic Kick", 25),
                    new Skill("Shield", 0, isDefensive: true)
                }),
                new StudentHero("Science Swordy", 100, new List<Skill>
                {
                    new Skill("Chemical Burn", 18),
                    new Skill("Heal", 20, isHealing: true),
                    new Skill("Physics Punch", 24),
                    new Skill("Defend", 0, isDefensive: true)
                }),
                new StudentHero("History Buff", 100, new List<Skill>
                {
                    new Skill("Time Blast", 19),
                    new Skill("Heal", 18, isHealing: true),
                    new Skill("Sword Slash", 25),
                    new Skill("Defend", 0, isDefensive: true)
                }),
                new StudentHero("The Englisher", 100, new List<Skill>
                {
                    new Skill("Book Smack", 23),
                    new Skill("Heal", 18, isHealing: true),
                    new Skill("Letter Dumping", 18),
                    new Skill("Defend", 0, isDefensive: true)
                })
            };
        }
    }

    public class Skill
    {
        public string Name { get; set; }
        public int Power { get; set; }
        public bool IsHealing { get; set; }
        public bool IsDefensive { get; set; }

        public Skill(string name, int power, bool isHealing = false, bool isDefensive = false)
        {
            Name = name;
            Power = power;
            IsHealing = isHealing;
            IsDefensive = isDefensive;
        }
    }
}