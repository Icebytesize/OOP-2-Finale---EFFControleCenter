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
        public static async Task OverwriteUnitsToJson(string fileName, IReadOnlyList<MobileUnit> units)
        {
            List<MobileUnitData> unitData = new();
            
            foreach (var unit in units)
            {
                unitData.Add(ConvertToUnitData(unit));
            }
            await JsonService.OverwriteJson(fileName, unitData);
        }

        /// <summary>
        /// Loads mobile units from a JSON file and recreates the correct concrete unit types.
        /// It also restores pilot and weapon relationships by matching the stored IDs
        /// with the already loaded pilots and weapons.
        /// </summary>
        /// <param name="fileName">The JSON file containing the mobile unit data.</param>
        /// <param name="allPilots">All loaded pilots used to restore pilot assignments.</param>
        /// <param name="allWeapons">All loaded weapons used to restore unit loadouts.</param>
        /// <returns>A list of recreated mobile units with their relationships restored.</returns>
        public static async Task<List<MobileUnit>> LoadUnitsFromJson(string fileName, List<Pilot> allPilots, List<Weapon> allWeapons)
        {
            List<MobileUnitData> unitData = await JsonService.LoadFromJson<MobileUnitData>(fileName);

            List<MobileUnit> units = new();

            foreach (MobileUnitData data in unitData)
            {
                // Recreate the correct concrete MobileUnit type from the saved type name.
                MobileUnit unit = data.Type switch
                {
                    "GM" => new GM(data.Name),
                    "GunCannon" => new GunCannon(data.Name),
                    "AquaGM" => new AquaGM(data.Name),
                    "Gundam" => new Gundam(data.Name),
                    "ZetaGundam" => new ZetaGundam(data.Name),

                    _ => throw new InvalidOperationException($"Unknown mobile unit type: {data.Type}")
                };

                unit.Id = data.Id;

                if (data.PilotId.HasValue)
                {
                    Pilot? pilot = allPilots.Find(p => p.Id == data.PilotId.Value);
                    if (pilot != null)
                    {
                        unit.AssignPilot(pilot);
                    }
                }

                if (unit is MobileWeapon mobileWeapon)
                {
                    foreach (int weaponId in data.WeaponIds)
                    {
                        Weapon? weapon = allWeapons.Find(w => w.Id == weaponId);

                        if (weapon != null)
                        {
                            mobileWeapon.AddWeapon(weapon);
                        }
                    }
                }

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
                Name = unit.Name,
                Type = unit.GetType().Name,
                PilotId = unit.AssignedPilot?.Id
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
