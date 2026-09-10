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

        /// <summary>
        /// Initializes a new instance of the Weapon class with the specified name, damage, and energy cost.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="damage"></param>
        /// <param name="energyCost"></param>
        /// <exception cref="ArgumentException"></exception>
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
        public override string ToString()
        {
            return Name;
        }
    }
}
