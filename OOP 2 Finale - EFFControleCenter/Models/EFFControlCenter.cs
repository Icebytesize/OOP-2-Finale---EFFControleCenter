using OOP_2_Finale___EFFControleCenter.Interfaces;
using OOP_2_Finale___EFFControleCenter.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2_Finale___EFFControleCenter.Models
{
    public class EFFControlCenter : Entity
    {
        private readonly List<Mission> _missions = new();
        private readonly List<Squad> _squads = new();
        private readonly List<Pilot> _pilots = new();
        private readonly List<MilitaryBase> _bases = new();
        private readonly List<Weapon> _weapons = new();
        private readonly List<MobileUnit> _units = new();
        private readonly IMissionAssignmentStrategy _assignmentStrategy;


        public IReadOnlyList<Mission> Missions => _missions;
        public IReadOnlyList<Squad> Squads => _squads;
        public IReadOnlyList<Pilot> Pilots => _pilots;
        public IReadOnlyList<MilitaryBase> Bases => _bases;
        public IReadOnlyList<Weapon> Weapons => _weapons;
        public IReadOnlyList<MobileUnit> Units => _units;

        public void AddMission(Mission mission)
        {
            ArgumentNullException.ThrowIfNull(mission);
            _missions.Add(mission);
        }
        public EFFControlCenter(IMissionAssignmentStrategy assignmentStrategy)
        {
            _assignmentStrategy = assignmentStrategy;
        }

        public void AddSquad(Squad squad)
        {
            ArgumentNullException.ThrowIfNull(squad);
            _squads.Add(squad);
        }
        
        public void AddPilot(Pilot pilot)
        {
            ArgumentNullException.ThrowIfNull(pilot);
            _pilots.Add(pilot);
        }

        public void AddBase(MilitaryBase militaryBase)
        {
            ArgumentNullException.ThrowIfNull(militaryBase);
            _bases.Add(militaryBase);
        }

        public void AddWeapon(Weapon weapon)
        {
            ArgumentNullException.ThrowIfNull(weapon);
            _weapons.Add(weapon);
        }

        public void AddUnit(MobileUnit unit)
        {
            ArgumentNullException.ThrowIfNull(unit);
            _units.Add(unit);
        }

        public Squad AssignSquadToMission(Mission mission)
        {
           
            ArgumentNullException.ThrowIfNull(mission);
            
            if (!_missions.Contains(mission))
            {
                throw new InvalidOperationException("Mission is not part of the control center.");
            }

            Squad squad = _assignmentStrategy.SelectSquad(mission, _squads);

            mission.AssignSquad(squad);

            return squad;
        }

        public Weapon? FindWeaponById(int id)
        {
            return _weapons.FirstOrDefault(w => w.Id == id);
        }

        public Pilot? FindPilotById(int id) 
        {
            return _pilots.FirstOrDefault(p => p.Id == id); 
        }

        public MobileUnit? FindUnitById(int id)
        {
            return _units.FirstOrDefault(u => u.Id == id);
        }

        public Squad? FindSquadById(int id)
        {
            return _squads.FirstOrDefault(s => s.Id == id);
        }

        public Mission? FindMissionById(int id)
        {
            return _missions.FirstOrDefault(m => m.Id == id);
        }

        public bool RemoveWeaponById(int id)
        {
            Weapon? weapon = FindWeaponById(id);

            if (weapon == null) return false;

            foreach (MobileUnit unit in _units)
            {
                if (unit is MobileWeapon mobileWeapon) mobileWeapon.RemoveWeapon(weapon);
            }

            return _weapons.Remove(weapon);
        }

        public bool RemovePilotById(int id)
        {
            Pilot? pilot = FindPilotById(id);

            if (pilot == null) return false;

            if (pilot.AssignedUnit != null) pilot.AssignedUnit.RemovePilot();

            return _pilots.Remove(pilot);
        }

        public bool RemoveUnitById(int id)
        {
            MobileUnit? unit = FindUnitById(id);

            if (unit == null) return false;

            if (!unit.IsAvailable) throw new InvalidOperationException("Cannot remove a mobile unit that is currently deployed");

            if (unit.AssignedPilot != null) unit.RemovePilot();

            if (unit.AssignedSquad != null) unit.AssignedSquad.RemoveUnit(unit);

            return _units.Remove(unit);
        }

        public bool RemoveSquadById(int id)
        {
            Squad? squad = FindSquadById(id); 
            
            if (squad == null) return false; 

            bool isAssignedToMission = _missions.Any(m => m.AssignedSquad == squad);
            if (isAssignedToMission) throw new InvalidOperationException("Cannot remove a squad that is assigned to a mission");

            foreach (MobileUnit unit in squad.Units.ToList()) squad.RemoveUnit(unit);
            
            return _squads.Remove(squad);
        }

    }
}
