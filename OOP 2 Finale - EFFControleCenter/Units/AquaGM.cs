using OOP_2_Finale___EFFControleCenter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2_Finale___EFFControleCenter.Units
{
    public class AquaGM : MassProduced, IUnderwaterCapable
    {
        public AquaGM()
            : base("Aqua GM", 110, 100)
        {
        }

        public override string GetDescription()
        {
            return "A modified GM designed for underwater operations.";
        }

        public void OperateUnderwater()
        {
            Console.WriteLine($"{Name} is operating underwater.");
        }


    }
}
