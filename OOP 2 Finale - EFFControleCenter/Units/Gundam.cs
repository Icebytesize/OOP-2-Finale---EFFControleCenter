using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2_Finale___EFFControleCenter.Units
{
    public class Gundam : Specialized
    {
        public Gundam()
            : base("Gundam", 180, 160)
        {
        }

        public override string GetDescription()
        {
            return "A high-performance prototype mobile suit.";
        }
    }
}
