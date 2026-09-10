using OOP_2_Finale___EFFControleCenter.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OOP_2_Finale___EFFControleCenter.Units;
using OOP_2_Finale___EFFControleCenter.Data;

namespace OOP_2_Finale___EFFControleCenter.Services
{
    internal class UnitJsonService
    {
        public static async Task OverwriteUnitsToJson(string fileName, List<MobileUnit> units)
        {
            List<MobileUnitData> unitData = new();
            
            foreach (var unit in units)
            {
                unitData.Add(ConvertToUnitData(unit));
            }
            await JsonService.OverwriteJson(fileName, unitData);
        }

        public static async Task<List<MobileUnit>> LoadUnitsFromJson(string fileName)
        {
            List<MobileUnitData> unitData = await JsonService.LoadFromJson<MobileUnitData>(fileName);

            List<MobileUnit> units = new();

            foreach (MobileUnitData data in unitData)
            {
                MobileUnit unit = data.Type switch
                {
                    "GM" => new GM(),
                    "GunCannon" => new GunCannon(),
                    "AquaGM" => new AquaGM(),
                    "Gundam" => new Gundam(),
                    "ZetaGundam" => new ZetaGundam(),

                    _ => throw new InvalidOperationException($"Unknown mobile unit type: {data.Type}")
                };

                unit.Id = data.Id;

                units.Add(unit);
            }

            return units;
        }
        public static async Task AppendUnitsToJson(string fileName, List<MobileUnit> newUnits)
        {
            ArgumentNullException.ThrowIfNull(newUnits);

            List<MobileUnitData> existingUnitData = await JsonService.LoadFromJson<MobileUnitData>(fileName);
            
            foreach (var unit in newUnits)
            {
                existingUnitData.Add(ConvertToUnitData(unit));
            }

            await JsonService.OverwriteJson(fileName, existingUnitData);
        }

        private static MobileUnitData ConvertToUnitData(MobileUnit unit)
        {
            MobileUnitData data = new MobileUnitData
            {
                Id = unit.Id,
                Type = unit.GetType().Name,
                PilotId = unit.AssignedPilot?.Id,
                SquadId = unit.AssignedSquad?.Id,
            };

            if (unit is MobileWeapon mobileWeapon)
            {
                foreach (var weapon in mobileWeapon.Loadout)
                {
                    data.WeaponIds.Add(weapon.Id);
                }
            }

            return data;
        }
    }
}
