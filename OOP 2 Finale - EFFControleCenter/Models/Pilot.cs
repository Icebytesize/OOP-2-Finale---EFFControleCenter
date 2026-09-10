using OOP_2_Finale___EFFControleCenter.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2_Finale___EFFControleCenter.Models
{
    public class Pilot : Entity
    {

        public string Name { get; }
        public MobileUnit? AssignedUnit { get; private set; }
        public Pilot(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Pilot name cannot be null or empty.", nameof(name));
            }
            Name = name;
            AssignedUnit = null;
        }
        internal void AssignUnit(MobileUnit unit)
        {
            ArgumentNullException.ThrowIfNull(unit);
            AssignedUnit = unit;
        }
        public override string ToString()
        {
            return Name;
        }
        internal void RemoveUnit()
        {
            AssignedUnit = null;
        }
    }
}
