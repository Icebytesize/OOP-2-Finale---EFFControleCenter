using OOP_2_Finale___EFFControleCenter.Data;
using OOP_2_Finale___EFFControleCenter.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2_Finale___EFFControleCenter.Services
{
    internal class PilotJsonService
    {
        private static PilotData ConvertToPilotData(Pilot pilot)
        {
            return new PilotData
            {
                Id = pilot.Id,
                Name = pilot.Name,
                
            };
        }

        public static async Task OverwritePilotsToJson(string fileName, IReadOnlyList<Pilot> pilots)
        {
            List<PilotData> pilotData = new();
            foreach (var pilot in pilots)
            {
                pilotData.Add(ConvertToPilotData(pilot));
            }
            await JsonService.OverwriteJson(fileName, pilotData);
        }

        public static async Task<List<Pilot>> LoadPilotsFromJson(string fileName)
        {
            List<PilotData> pilotData = await JsonService.LoadFromJson<PilotData>(fileName);

            List<Pilot> pilots = new();

            foreach (PilotData data in pilotData)
            {
                Pilot pilot = new Pilot(data.Name)
                {
                    Id = data.Id
                };

                pilots.Add(pilot);
            }

            return pilots;
        }
    }
}
