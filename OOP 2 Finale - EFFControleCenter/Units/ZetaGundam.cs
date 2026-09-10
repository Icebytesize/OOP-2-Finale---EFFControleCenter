using OOP_2_Finale___EFFControleCenter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2_Finale___EFFControleCenter.Units
{
    public class ZetaGundam : Specialized, IFlyable
    {
        public ZetaGundam()
            : base("Zeta Gundam", 170, 180)
        {
        }

        public override string GetDescription()
        {
            return "A transformable high-performance mobile suit capable of atmospheric flight.";
        }
      
        public void Fly()
        {
            Console.WriteLine($"{Name} is flying.");
        }
    }
}
