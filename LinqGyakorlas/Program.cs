using System;
using System.Collections.Generic;

namespace LinqGyakorlas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Starship> initialShips = GetInitialData();
            FleetManager manager = new FleetManager(initialShips);

            Console.WriteLine($"A flotta sikeresen betöltve {initialShips.Count} űrhajóval.");
            Console.WriteLine("A LINQ metódusok megvalósításra várnak!");
        }

        public static List<Starship> GetInitialData()
        {
            return new List<Starship>
            {
                new Starship("NX-01", "Enterprise", ShipType.Explorer, 85, 5.2, true, new DateTime(2151, 4, 16)),
                new Starship("NCC-1701", "Enterprise-A", ShipType.Explorer, 430, 8.0, true, new DateTime(2245, 2, 11)),
                new Starship("NCC-1701-D", "Enterprise-D", ShipType.Explorer, 1014, 9.6, true, new DateTime(2363, 10, 4)),
                new Starship("NCC-74656", "SS Voyager", ShipType.Explorer, 141, 9.975, true, new DateTime(2371, 1, 21)),
                new Starship("NX-74205", "Defiant", ShipType.Fighter, 50, 9.0, true, new DateTime(2370, 6, 8)),
                new Starship("CRG-001", "Bebop Cargo", ShipType.Cargo, 4, 3.5, false, new DateTime(2071, 3, 15)),
                new Starship("CRG-002", "SS Nostromo", ShipType.Cargo, 7, 2.1, false, new DateTime(2122, 5, 25)),
                new Starship("MNG-101", "USG Ishimura", ShipType.Mining, 1000, 4.0, false, new DateTime(2478, 11, 12)),
                new Starship("MED-001", "SS Hope", ShipType.Medical, 120, 6.5, true, new DateTime(2290, 8, 30)),
                new Starship("MED-002", "Nightingale", ShipType.Medical, 45, 7.2, true, new DateTime(2315, 12, 1)),
                new Starship("EXP-002", "Endurance", ShipType.Explorer, 4, 4.8, false, new DateTime(2067, 11, 7)),
                new Starship("FTR-001", "X-Wing Red 5", ShipType.Fighter, 1, 8.5, true, new DateTime(2180, 5, 4)),
                new Starship("FTR-002", "Tie Interceptor", ShipType.Fighter, 1, 8.8, false, new DateTime(2181, 9, 14)),
                new Starship("CRG-003", "SS Razorcrest", ShipType.Cargo, 2, 6.0, true, new DateTime(2210, 4, 18)),
                new Starship("MNG-102", "Deep Miner Alpha", ShipType.Mining, 300, 3.2, true, new DateTime(2301, 7, 22)),
                new Starship("MNG-103", "Asteroid Cracker", ShipType.Mining, 150, 2.9, false, new DateTime(2285, 1, 19)),
                new Starship("EXP-003", "Discovery", ShipType.Explorer, 135, 9.1, true, new DateTime(2256, 5, 11)),
                new Starship("FTR-003", "SS Valkyrie", ShipType.Fighter, 12, 9.4, true, new DateTime(2380, 3, 29)),
                new Starship("CRG-004", "Hauler Giant", ShipType.Cargo, 25, 2.8, false, new DateTime(2240, 10, 10)),
                new Starship("MED-003", "Asclepius", ShipType.Medical, 200, 6.0, true, new DateTime(2350, 2, 14)),
                new Starship("EXP-004", "SS Odyssey", ShipType.Explorer, 350, 7.8, true, new DateTime(2333, 9, 9)),
                new Starship("FTR-004", "Phantom Striker", ShipType.Fighter, 2, 9.9, true, new DateTime(2395, 11, 30)),
                new Starship("CRG-005", "Freighter One", ShipType.Cargo, 15, 4.1, false, new DateTime(2199, 6, 1)),
                new Starship("MNG-104", "Planet Express", ShipType.Cargo, 3, 7.5, true, new DateTime(2999, 12, 31)),
                new Starship("EXP-005", "SS Horizon", ShipType.Explorer, 500, 8.3, false, new DateTime(2277, 4, 5))
            };
        }
    }
}