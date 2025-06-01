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

        private int defenseTurnsRemaining = 0;

        public Character(string name, int maxHealth, List<Skill> skills)
        {
            Name = name;
            MaxHealth = maxHealth;
            Health = maxHealth;
            Skills = skills;
        }

        public void Heal(int amount)
        {
            Health += amount;
            if (Health > MaxHealth)
                Health = MaxHealth;
        }

        public void ReceiveDamage(int amount)
        {
            int damageToTake = defenseTurnsRemaining > 0 ? amount / 2 : amount;
            Health -= damageToTake;

            if (Health < 0)
                Health = 0;
        }

        public void ActivateDefense()
        {
            defenseTurnsRemaining = 3;
        }

        public void DecrementDefense()
        {
            if (defenseTurnsRemaining > 0)
                defenseTurnsRemaining--;
        }

        public bool IsDefending()
        {
            return defenseTurnsRemaining > 0;
        }
    }
}
