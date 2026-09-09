using System;
using System.Collections.Generic;
using System.Text;
using OOP_2_Finale___EFFControleCenter.MobileUnits;
using OOP_2_Finale___EFFControleCenter.Models;

namespace OOP_2_Finale___EFFControleCenter.Models
{
    public abstract class MobileWeapon : MobileUnit
    {
        private const int MaxWeapons =  3;
        private readonly List<Weapon> _loadout = new();
        public IReadOnlyList<Weapon> Loadout => _loadout.AsReadOnly();

        protected MobileWeapon(string name, int health, int energy) : base(name, health, energy)
        {
        }

        public void AddWeapon(Weapon weapon)
        {
            ArgumentNullException.ThrowIfNull(weapon);
            if (_loadout.Count >= MaxWeapons)
            {
                throw new InvalidOperationException($"Cannot add more than {MaxWeapons} weapons to the loadout.");
            }
            _loadout.Add(weapon);
        }

        public void RemoveWeapon(Weapon weapon)
        {
            ArgumentNullException.ThrowIfNull(weapon);
            if (!_loadout.Remove(weapon))
            {
                throw new InvalidOperationException("The specified weapon is not in the loadout.");
            }
        }
    }
}
