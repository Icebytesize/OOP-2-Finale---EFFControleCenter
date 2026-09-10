using OOP_2_Finale___EFFControleCenter.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2_Finale___EFFControleCenter.Models
{
    public class EFFControlCenter : Entity
    {
        private readonly List<Mission> _mission = new();
        private readonly List<Squad> _squad = new();
        private readonly List<Pilot> _pilot = new();
        private readonly List<MilitaryBase> _bases = new();
        private readonly List<Weapon> _weapon = new();
        private readonly List<MobileUnit> _unit = new();


        public IReadOnlyList<Mission> Missions => _mission;
        public IReadOnlyList<Squad> Squads => _squad;
        public IReadOnlyList<Pilot> Pilots => _pilot;
        public IReadOnlyList<MilitaryBase> Bases => _bases;
        public IReadOnlyList<Weapon> Weapons => _weapon;
        public IReadOnlyList<MobileUnit> Unit => _unit;

        public void AddMission(Mission mission)
        {
            ArgumentNullException.ThrowIfNull(mission);
            _mission.Add(mission);
        }

        public void AddSquad(Squad squad)
        {
            ArgumentNullException.ThrowIfNull(squad);
            _squad.Add(squad);
        }
        
        public void AddPilot(Pilot pilot)
        {
            ArgumentNullException.ThrowIfNull(pilot);
            _pilot.Add(pilot);
        }

        public void AddBase(MilitaryBase militaryBase)
        {
            ArgumentNullException.ThrowIfNull(militaryBase);
            _bases.Add(militaryBase);
        }

        public void AddWeapon(Weapon weapon)
        {
            ArgumentNullException.ThrowIfNull(weapon);
            _weapon.Add(weapon);
        }

        public void AddUnit(MobileUnit unit)
        {
            ArgumentNullException.ThrowIfNull(unit);
            _unit.Add(unit);
        }

        public void AssignSquadToMission(Squad squad, Mission mission)
        {
            ArgumentNullException.ThrowIfNull(squad);
            ArgumentNullException.ThrowIfNull(mission);
            if (!_squad.Contains(squad))
            {
                throw new InvalidOperationException("Squad is not part of the control center.");
            }
            if (!_mission.Contains(mission))
            {
                throw new InvalidOperationException("Mission is not part of the control center.");
            }
            mission.AssignSquad(squad);
        }

    }
}
