using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2_Finale___EFFControleCenter.Models
{
    public class Weapon : Entity
    {
        public string Name { get;  }
        public int Damage { get; }
        public int EnergyCost { get; }

        public Weapon(string name, int damage, int energyCost)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Weapon name cannot be null or empty.", nameof(name));
            }
            if (damage <= 0)
            {
                throw new ArgumentException("Damage must be greater than zero.", nameof(damage));
            }
            if (energyCost < 0)
            {
                throw new ArgumentException("Energy cost cannot be negative.", nameof(energyCost));
            }
            Name = name;
            Damage = damage;
            EnergyCost = energyCost;
        }

    }
}
