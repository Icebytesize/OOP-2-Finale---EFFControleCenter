using OOP_2_Finale___EFFControleCenter.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2_Finale___EFFControleCenter.Units
{
    public abstract class MobileUnit
    {
        
        public string Name { get; set; }
        public int Health { get; private set; }
        public int energy { get; private set; }
        public bool IsAvaible { get; private set; }
        public Pilot? AssignedPilot { get; private set; }

        /// <summary>
        /// Initializes a new instance of the MobileUnit class with the specified name, health, and energy.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="health"></param>
        /// <param name="energy"></param>
        /// <exception cref="ArgumentException"></exception>
        protected MobileUnit(string name, int health, int energy)
        {
            
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("A Mobile Unit must have a name.");
            }

            if (health <= 0)
            {
                throw new ArgumentException("Health must be greater than zero.");
            }

            if (energy < 0)
            {
                throw new ArgumentException("Energy cannot be negative.");
            }


            Name = name;
            Health = health;
            energy = energy;
            IsAvaible = true;
            AssignedPilot = null;
        }

        public void AssignPilot(Pilot pilot)
        {
            ArgumentNullException.ThrowIfNull(pilot);

            AssignedPilot = pilot;
            pilot.AssignUnit(this);
        }

        public void RemovePilot()
        {
            if (AssignedPilot != null)
            {
                AssignedPilot.RemoveUnit();
            }
            AssignedPilot = null;
        }

        public void Deploy()
        {
            if(!IsAvaible) 
            {
                throw new InvalidOperationException("This mobile unit is not available for deployment.");
            }

            IsAvaible = false;
        }

        public abstract string GetDescription();
    }
}
