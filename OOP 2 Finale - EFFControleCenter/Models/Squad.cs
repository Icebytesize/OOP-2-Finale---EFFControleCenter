using System;
using System.Collections.Generic;
using System.Text;
using OOP_2_Finale___EFFControleCenter.Units;

namespace OOP_2_Finale___EFFControleCenter.Models
{
    public class Squad : Entity
    {
        public string Name { get; }
        private readonly List<MobileUnit> _units = new();
        public IReadOnlyList<MobileUnit> Units => _units;
        const int MaxUnits = 4;

        public Squad(string name)
        {
            Name = name;
        }

        public void AddUnit(MobileUnit unit)
        {
            ArgumentNullException.ThrowIfNull(unit);

            if (Units.Count >= MaxUnits)
                throw new InvalidOperationException($"Cannot add more than {MaxUnits} units to the squad.");

            if (unit.AssignedSquad != null)
                throw new InvalidOperationException($"Unit {unit.Name} is already assigned to a squad.");

            _units.Add(unit);
            unit.SetSquad(this);
        }
       

        public void RemoveUnit(MobileUnit unit)
        {
            ArgumentNullException.ThrowIfNull(unit);
            if (_units.Remove(unit))
            {
                unit.SetSquad(null);
            }
        }

        /// <summary>
        /// Checks if the squad is ready for a mission. A squad is considered ready if it has at least one unit and all units are available.
        /// </summary>
        /// <returns></returns>
        public bool IsReadyForMission()
        {
            if (_units.Count == 0)
            {
                return false;
            }

            foreach (var unit in Units)
            {
                if (!unit.IsAvailable)
                {
                    
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Displays information about the squad, including its name and the details of each unit in the squad.
        /// </summary>
        public void DisplaySquadInfo()
        {
            Console.WriteLine($"Squad Name: {Name}");
            Console.WriteLine("Units in Squad:");

            foreach (var unit in Units)
            {
                Console.WriteLine($"-{unit.GetStatus()}");
            }
        }
        public void DisplaySquadDescription()
        {
            Console.WriteLine($"Squad Name: {Name}");
            Console.WriteLine("Units in Squad:");

            foreach (var unit in Units)
            {
                Console.WriteLine($"-{unit.GetDescription()}");
            }
        }

    }
}
