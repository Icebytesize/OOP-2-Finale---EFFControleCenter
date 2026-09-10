using OOP_2_Finale___EFFControleCenter.Enums;
using OOP_2_Finale___EFFControleCenter.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2_Finale___EFFControleCenter.Models
{
    public class Mission : Entity
    {
        public string Name { get; }
        public string Description { get; }
        public TerrainType Terrain { get; }
        public MissionStatus Status { get; private set; }

        public Squad? AssignedSquad { get; private set; }

        public Mission(string name, string description, TerrainType terrain)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Mission name cannot be null or empty.", nameof(name));
            }

            Name = name;
            Description = description;
            Terrain = terrain;
            Status = MissionStatus.Pending;
            AssignedSquad = null;
        }

        public void AssignSquad(Squad squad)
        {
            ArgumentNullException.ThrowIfNull(squad);

            AssignedSquad = squad;
        }

        public void StartMission()
        {
            if (Status != MissionStatus.Pending)
            {
                throw new InvalidOperationException("Mission can only be started if it is pending.");
            }

            if (AssignedSquad == null)
            {
                throw new InvalidOperationException("Cannot start mission without an assigned squad.");
            }

            if (!AssignedSquad.IsReadyForMission())
            {
                throw new InvalidOperationException("Assigned squad is not ready for the mission.");
            }

            foreach (var unit in AssignedSquad.Units)
            {
                unit.Deploy();
            }

            Status = MissionStatus.InProgress;
        }

        public void CompleteMission()
        {
            if (Status != MissionStatus.InProgress)
            {
                throw new InvalidOperationException("Mission can only be completed if it is in progress.");
            }
            Status = MissionStatus.Completed;
        }

        /// <summary>
        /// Displays detailed information about the mission, including its name, description, terrain type, status, and assigned squad details if available.
        /// </summary>
        public void MissionInfo()
        {
            Console.WriteLine($"Mission: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Terrain: {Terrain}");
            Console.WriteLine($"Status: {Status}");
            
            if (AssignedSquad != null)
            {
                AssignedSquad.DisplaySquadInfo();
            }
            else
            {
                Console.WriteLine("Assigned Squad: None");
            }
        }
    }
}


