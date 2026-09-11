using OOP_2_Finale___EFFControleCenter.Interfaces;
using OOP_2_Finale___EFFControleCenter.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2_Finale___EFFControleCenter.Models
{
    internal class FirstAvailableSquadStrategy : IMissionAssignmentStrategy
    {
        public Squad SelectSquad(Mission mission, IEnumerable<Squad> squads)
        {
            Squad? squad = squads.FirstOrDefault(s => s.IsReadyForMission());

            if (squad != null)
            {
                throw new SquadNotReadyException("No available squad could be found for this mission.");
            }

            return squad;
        }
    }
}
