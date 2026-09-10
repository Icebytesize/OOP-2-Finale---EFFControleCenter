using OOP_2_Finale___EFFControleCenter.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2_Finale___EFFControleCenter.Data
{
    public class SquadData : Entity
    {
        public string Name { get; set; } = "";
        public List<int> UnitIds { get; set; } = new();
        
    }
}
