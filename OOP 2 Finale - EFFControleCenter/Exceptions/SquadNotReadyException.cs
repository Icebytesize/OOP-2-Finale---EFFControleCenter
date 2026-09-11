using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2_Finale___EFFControleCenter.Exceptions
{
    internal class SquadNotReadyException : Exception
    {
        public SquadNotReadyException(string message) : base(message) { }
    }
}
