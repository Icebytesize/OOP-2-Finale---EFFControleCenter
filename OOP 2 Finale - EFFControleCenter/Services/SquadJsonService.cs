using OOP_2_Finale___EFFControleCenter.Data;
using OOP_2_Finale___EFFControleCenter.Models;
using OOP_2_Finale___EFFControleCenter.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2_Finale___EFFControleCenter.Services
{
    internal class SquadJsonService
    {
        private static SquadData ConvertToSquadData(Squad squad)
        {
            SquadData data = new SquadData
            {
                Id = squad.Id,
                Name = squad.Name,
            };

            foreach (var unit in squad.Units)
            {
                data.UnitIds.Add(unit.Id);
            }

            return data;
        }


        public static async Task OverwriteSquadsToJson(string fileName, IReadOnlyList<Squad> squads)
        {
            List<SquadData> squadData = new();
            foreach (var squad in squads)
            {
                squadData.Add(ConvertToSquadData(squad));
            }
            await JsonService.OverwriteJson(fileName, squadData);
        }

        public static async Task<List<Squad>> LoadSquadsFromJson(string fileName, List<MobileUnit> allUnits)
        {
            List<SquadData> squadData = await JsonService.LoadFromJson<SquadData>(fileName);

            List<Squad> squads = new();

            foreach (SquadData data in squadData)
            {
                Squad squad = new Squad(data.Name)
                {
                    Id = data.Id

                };


                foreach (int unitId in data.UnitIds)
                {
                    MobileUnit? unit = allUnits.Find(u => u.Id == unitId);

                    if (unit != null)
                    {
                        squad.AddUnit(unit);
                    }
                }

                squads.Add(squad);
            }

            return squads;
        }

        public static async Task AppendSquadsToJson(string fileName, List<Squad> newSquads)
        {
            ArgumentNullException.ThrowIfNull(newSquads);
            List<SquadData> existingSquadData = await JsonService.LoadFromJson<SquadData>(fileName);
            foreach (var squad in newSquads)
            {
                existingSquadData.Add(ConvertToSquadData(squad));
            }
            await JsonService.OverwriteJson(fileName, existingSquadData);
        }
    }
}
