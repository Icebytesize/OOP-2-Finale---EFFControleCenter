using OOP_2_Finale___EFFControleCenter.Enums;
using OOP_2_Finale___EFFControleCenter.Models;
using OOP_2_Finale___EFFControleCenter.Units;

var controlCenter = new EFFControlCenter();

var gm = new GM();
var gundam = new Gundam();
var aquaGM = new AquaGM();

var squad1 = new Squad("Squad-1");

squad1.AddUnit(gm);
squad1.AddUnit(gundam);
squad1.AddUnit(aquaGM);

squad1.DisplaySquadDescription();

Console.WriteLine();

var mission = new Mission(
    "Operation Odessa",
    "Secure the area and eliminate hostile forces.",
    TerrainType.Urban
);

controlCenter.AddSquad(squad1);
controlCenter.AddMission(mission);

controlCenter.AssignSquadToMission(squad1, mission);

mission.MissionInfo();

Console.WriteLine();

mission.StartMission();

mission.MissionInfo();
Console.ReadKey();
