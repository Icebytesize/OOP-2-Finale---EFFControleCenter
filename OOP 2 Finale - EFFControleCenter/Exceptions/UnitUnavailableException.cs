using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2_Finale___EFFControleCenter.Exceptions
{
    public class UnitUnavailableException : Exception
    {
        public UnitUnavailableException(string message) : base(message) { }
    }
}
