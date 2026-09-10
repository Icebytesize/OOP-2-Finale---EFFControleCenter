using OOP_2_Finale___EFFControleCenter.Enums;
using OOP_2_Finale___EFFControleCenter.Models;
using OOP_2_Finale___EFFControleCenter.Services;
using OOP_2_Finale___EFFControleCenter.Units;



List<Pilot> EmptyPilots = new List<Pilot>();
await JsonService.OverwriteJson("pilots.json", EmptyPilots);


var controlCenter = new EFFControlCenter();

var pilots = new List<Pilot>
{
    new Pilot("Amuro Ray"),
    new Pilot("Sayla Mass"),
    new Pilot("Hayato Kobayashi")
};

int nextId = await JsonService.GetNextId<Pilot>("pilots.json");

foreach (Pilot pilot in pilots)
{
    pilot.Id = nextId;
    nextId++;
}


await JsonService.OverwriteJson("pilots.json", pilots);

List<Pilot> loadedPilots = await JsonService.LoadFromJson<Pilot>("pilots.json");

foreach (Pilot pilot in loadedPilots)
{
    Console.WriteLine($"Pilot: {pilot.Name}, ID: {pilot.Id}");
}
