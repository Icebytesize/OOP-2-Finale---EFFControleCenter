using System;
using System.Collections.Generic;
using System.Text;
using OOP_2_Finale___EFFControleCenter.Enums;
using OOP_2_Finale___EFFControleCenter.Models;

namespace OOP_2_Finale___EFFControleCenter.Data
{
    internal class MissionData : Entity
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public TerrainType Terrain { get; set; }
        public MissionStatus MissionStatus { get; set; }
        public TimeSpan Duration { get; set; }
        public int? AssignedSquadId { get; set; }
    }
}
