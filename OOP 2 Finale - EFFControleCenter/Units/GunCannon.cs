using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2_Finale___EFFControleCenter.Units
{
    public class GunCannon : MassProduced
    {
        public GunCannon()
            : base("GunCannon", 130, 110)
        {
        }

        public override string GetDescription()
        {
            return "A heavily armed mass-produced mobile suit focused on ranged combat.";
        }
    }
}
