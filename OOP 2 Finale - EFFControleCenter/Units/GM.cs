using System;
using System.Collections.Generic;
using System.Text;
using OOP_2_Finale___EFFControleCenter.Units;

namespace OOP_2_Finale___EFFControleCenter.Units
{
    public class GM : MassProduced
    {
        public GM()
            : base("GM", 100, 100)
        {
        }

        public override string GetDescription()
        {
            return "A standard mass-produced mobile suit used by the Earth Federation.";
        }
    }
}
