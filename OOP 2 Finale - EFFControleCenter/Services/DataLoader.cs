using OOP_2_Finale___EFFControleCenter.Models;
using System;
using System.Collections.Generic;
using System.Text;
using OOP_2_Finale___EFFControleCenter.Units;

namespace OOP_2_Finale___EFFControleCenter.Services
{
    internal class DataLoader
    {
        public static async Task<EFFControlCenter> LoadAllData()
        {
            EFFControlCenter controlCenter = new EFFControlCenter();
            // Load weapons
            List<Weapon> weapons = await JsonService.LoadFromJson<Weapon>("weapons.json");
            // Load Pilots
            List<Pilot> pilots = await JsonService.LoadFromJson<Pilot>("pilots.json");
            // Load Units
            List<MobileUnit> units = await UnitJsonService.LoadUnitsFromJson("units.json", pilots, weapons);
            // Load Squads
            List<Squad> squads = await SquadJsonService.LoadSquadsFromJson("squads.json", units);
            // Load Missions
            List<Mission> missions = await MissionJsonService.LoadMissionsFromJson("missions.json", squads);

            foreach (Weapon weapon in weapons)
            {
                controlCenter.AddWeapon(weapon);
            }

            foreach (Pilot pilot in pilots)
            {
                controlCenter.AddPilot(pilot);
            }

            foreach (Squad squad in squads)
            {
                controlCenter.AddSquad(squad);
            }

            foreach(Mission mission in missions)
            {
                controlCenter.AddMission(mission);
            }

            foreach(MobileUnit unit in units)
            { 
                controlCenter.AddUnit(unit); 
            }

            return controlCenter;
        }
    }
}
