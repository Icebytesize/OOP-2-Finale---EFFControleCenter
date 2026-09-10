using OOP_2_Finale___EFFControleCenter.Enums;
using OOP_2_Finale___EFFControleCenter.Models;
using OOP_2_Finale___EFFControleCenter.Units;

var gm = new GM();
var gundam = new Gundam();
var aquaGM = new AquaGM();

var squad1 = new Squad("Squad-1");

squad1.AddUnit(gm);
squad1.AddUnit(gundam);
squad1.AddUnit(aquaGM);

squad1.DisplaySquadInfo();

Console.WriteLine();

var mission = new Mission(
    "Operation Odessa",
    "Secure the area and eliminate hostile forces.",
    TerrainType.Urban
);

mission.AssignSquad(squad1);

Console.WriteLine($"Mission: {mission.Name}");
Console.WriteLine($"Status: {mission.Status}");
Console.WriteLine($"Squad: {mission.AssignedSquad?.Name}");

Console.WriteLine();

mission.StartMission();

Console.WriteLine($"Status after start: {mission.Status}");
Console.WriteLine($"Squad ready: {squad1.IsReadyForMission()}");