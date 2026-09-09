using System;
using System.Collections.Generic;
using System.Text;
using OOP_2_Finale___EFFControleCenter.Interfaces;
using OOP_2_Finale___EFFControleCenter.Models;

namespace OOP_2_Finale___EFFControleCenter.Units
{
    public abstract class MassProduced : MobileWeapon
    {
        public MassProduced(string name, int health, int firepower, List<Weapon> loadout)
            : base(name, health, firepower, loadout)
        {
        }
    }
}
