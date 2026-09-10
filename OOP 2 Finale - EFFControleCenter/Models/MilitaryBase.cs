using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2_Finale___EFFControleCenter.Models
{
    public class MilitaryBase
    {
        public string Name { get; set; }
        public string Location { get; set; } = string.Empty;
        public string Department { get; set; }
        List<Squad> Squads { get; set; } = new();

        public MilitaryBase(string name, string location, string department)
        {
            Name = name;
            Location = location;
            Department = department;
            Squads = new List<Squad>();
        }
    }
}
