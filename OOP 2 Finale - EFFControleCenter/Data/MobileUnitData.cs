using OOP_2_Finale___EFFControleCenter.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2_Finale___EFFControleCenter.Data
{
    internal class MobileUnitData : Entity
    {
        public string Type { get; set; } = "";

        public int? PilotId { get; set; }
        public List<int> WeaponIds { get; set; } = new();
    }
}
