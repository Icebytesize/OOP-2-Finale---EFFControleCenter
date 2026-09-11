# EFF Control Center

## Projektbeskrivelse

EFF Control Center er et C#/.NET projekt udviklet som afsluttende projekt i OOP 2.

Programmet simulerer et kontrolcenter for Earth Federation Forces, hvor brugeren kan administrere Mobile Units, Pilots, Squads, Weapons, Missions og Military Bases.

Projektet er bygget med fokus på objektorienteret programmering og demonstrerer blandt andet:

- Arv
- Interfaces
- Polymorfi
- Encapsulation
- Generics
- Lambda expressions
- Callbacks og events
- Custom exceptions
- Dependency Inversion
- Strategy Pattern
- JSON persistence
- Asynkron programmering

---

## Funktioner

Programmet kan blandt andet:

- Oprette Mobile Units
- Oprette Pilots
- Oprette Weapons
- Oprette Squads
- Tilknytte Mobile Units til Squads
- Tilknytte Pilots til Mobile Units
- Tilføje Weapons til Mobile Weapons
- Oprette Missions
- Angive Location, Terrain og Threat Level på Missions
- Tilknytte et Squad til en Mission
- Starte Missions asynkront
- Logge hændelser i programmet
- Gemme og indlæse data fra JSON-filer
- Filtrere collections gennem en generisk filtermetode

---

## Projektstruktur

Projektet er opdelt i flere mapper med forskellige ansvarsområder.

Eksempel:

```text
OOP_2_Finale___EFFControleCenter
│
├── Data
├── Enums
├── Exceptions
├── Interfaces
├── Models
├── Resources
├── Services
├── Strategies
├── Units
├── Utilities
├── WinForms
│
└── Program.cs
