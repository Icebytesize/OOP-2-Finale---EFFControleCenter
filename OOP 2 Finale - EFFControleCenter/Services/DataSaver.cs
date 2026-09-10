using System;
using System.Collections.Generic;
using System.Text;
using OOP_2_Finale___EFFControleCenter.Models;
using OOP_2_Finale___EFFControleCenter.Units;

namespace OOP_2_Finale___EFFControleCenter.Services
{
    internal class DataSaver
    {
        public static async Task SaveAllData(EFFControlCenter controlCenter)
        {
            ArgumentNullException.ThrowIfNull(controlCenter);

            await JsonService.OverwriteJson("weapons.json", controlCenter.Weapons);

            await JsonService.OverwriteJson("pilots.json", controlCenter.Pilots);

            await UnitJsonService.OverwriteUnitsToJson("units.json", controlCenter.Units);

            await SquadJsonService.OverwriteSquadsToJson("squads.json", controlCenter.Squads);

            await MissionJsonService.OverwriteMissionsToJson("missions.json", controlCenter.Missions);
        }
    }
}
