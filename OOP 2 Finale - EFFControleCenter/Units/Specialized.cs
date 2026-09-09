using System;
using System.Collections.Generic;
using System.Text;
using OOP_2_Finale___EFFControleCenter.Units;
using OOP_2_Finale___EFFControleCenter.Models;

namespace OOP_2_Finale___EFFControleCenter.Units
{
    public abstract class Specialized : MobileWeapon
    {


        public Specialized(string name, int health, int energy, List<Weapon> loadout)
            : base(name, health, energy, loadout)
        {

        }
    }
}
