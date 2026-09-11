using OOP_2_Finale___EFFControleCenter.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2_Finale___EFFControleCenter.Interfaces
{
    public interface IMissionAssignmentStrategy
    {
        Squad SelectSquad(Mission mission, IEnumerable<Squad> squads);
    }
}
