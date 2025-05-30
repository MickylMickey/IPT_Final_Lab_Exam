using System;
using System.Collections.Generic;

namespace ClassroomBattleSimulator
{
    public class Character
    {
        public string Name { get; set; }
        public int MaxHealth { get; set; }
        public int Health { get; set; }
        public List<Skill> Skills { get; set; }

        private int defenseTurnsLeft = 0;

        public Character(string name, int maxHealth, List<Skill> skills)
        {
            Name = name;
            MaxHealth = maxHealth;
            Health = maxHealth;  // Set initial health to max
            Skills = skills;
        }

        public void Heal(int amount)
        {
            Health += amount;
            if (Health > MaxHealth)
                Health = MaxHealth;
        }

        public void ReceiveDamage(int damage)
        {
            if (defenseTurnsLeft > 0)
                damage = damage / 2; // Reduce damage by half when defense is active

            Health -= damage;
            if (Health < 0)
                Health = 0;
        }

        public void ActivateDefense()
        {
            defenseTurnsLeft = 3; // defense lasts 3 turns
        }

        public void DecrementDefense()
        {
            if (defenseTurnsLeft > 0)
                defenseTurnsLeft--;
        }
    }
}
