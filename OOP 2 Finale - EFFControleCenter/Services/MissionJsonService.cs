using System;
using System.Collections.Generic;
using System.Text;
using OOP_2_Finale___EFFControleCenter.Data;
using OOP_2_Finale___EFFControleCenter.Models;

namespace OOP_2_Finale___EFFControleCenter.Services
{
    internal class MissionJsonService
    {
        private static MissionData ConvertToMissionData(Mission mission)
        {
            MissionData data = new MissionData
            {
                Id = mission.Id,
                Name = mission.Name,
                Description = mission.Description,
                Terrain = mission.Terrain,
                MissionStatus = mission.Status,
                AssignedSquadId = mission.AssignedSquad?.Id,
                Location = mission.Location,
                ThreatLevel = mission.ThreatLevel,
                Duration = mission.Duration
            };
            return data;
        }
        public static async Task OverwriteMissionsToJson(string fileName, IReadOnlyList<Mission> missions)
        {
            List<MissionData> missionData = new();
            foreach (var mission in missions)
            {
                missionData.Add(ConvertToMissionData(mission));
            }
            await JsonService.OverwriteJson(fileName, missionData);
        }
        public static async Task<List<Mission>> LoadMissionsFromJson(string fileName, List<Squad> allSquads)
        {
            List<MissionData> missionData = await JsonService.LoadFromJson<MissionData>(fileName);
            List<Mission> missions = new();
            foreach (MissionData data in missionData)
            {
                Mission mission = new Mission(data.Name, data.Description, data.Location, data.ThreatLevel ,data.Terrain, data.Duration)
                {
                    Id = data.Id,
                };

                if (data.AssignedSquadId.HasValue)
                {
                    Squad? assignedSquad = allSquads.Find(s => s.Id == data.AssignedSquadId.Value);

                    if (assignedSquad != null)
                    {
                        mission.AssignSquad(assignedSquad);
                    }
                }

                mission.SetStatus(data.MissionStatus);
                
                missions.Add(mission);
            }
            return missions;
        }
        public static async Task AppendMissionsToJson(string fileName, List<Mission> newMissions)
        {
            ArgumentNullException.ThrowIfNull(newMissions);
            List<MissionData> existingMissionData = await JsonService.LoadFromJson<MissionData>(fileName);
            foreach (var mission in newMissions)
            {
                existingMissionData.Add(ConvertToMissionData(mission));
            }
            await JsonService.OverwriteJson(fileName, existingMissionData);
        }
    }
}
