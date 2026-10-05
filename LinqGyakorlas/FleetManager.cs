using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqGyakorlas
{
    public class FleetManager
    {
        // Privát adattag a listának
        private List<Starship> _ships;

        // Konstruktor
        public FleetManager(List<Starship> ships)
        {
            _ships = ships;
        }

        // 1. Feladat: Add vissza az összes 5-ös Warp sebességnél gyorsabb űrhajót!
        public List<Starship> GetFastShips()
        {
            throw new NotImplementedException();
        }

        // 2. Feladat: Add vissza a Cargo típusú űrhajók nevét egy listában!
        public List<string> GetCargoShipNames()
        {
            throw new NotImplementedException();
        }

        // 3. Feladat: Hány olyan űrhajó van, aminek a pajzsa jelenleg aktív?
        public int GetActiveShieldCount()
        {
            throw new NotImplementedException();
        }

        // 4. Feladat: Van-e olyan űrhajó a flottában, aminek a legénysége meghaladja az 1000 főt? (bool)
        public bool HasShipWithLargeCrew()
        {
            throw new NotImplementedException();
        }

        // 5. Feladat: Mindegyik űrhajó 2200 után került állományba? (bool)
        public bool AreAllShipsModern()
        {
            throw new NotImplementedException();
        }

        // 6. Feladat: Add vissza a legynagyobb legénységgel rendelkező űrhajót!
        public Starship GetShipWithLargestCrew()
        {
            throw new NotImplementedException();
        }

        // 7. Feladat: Számítsd ki az összes űrhajón szolgáló legénység összlétszámát!
        public int GetTotalCrewCount()
        {
            throw new NotImplementedException();
        }

        // 8. Feladat: Mennyi az Explorer típusú hajók átlagos maximális sebessége?
        public double GetAverageExplorerSpeed()
        {
            throw new NotImplementedException();
        }

        // 9. Feladat: Add vissza az űrhajókat sebesség szerint csökkenő sorrendben!
        public List<Starship> GetShipsOrderedBySpeedDescending()
        {
            throw new NotImplementedException();
        }

        // 10. Feladat: Rendezd a hajókat típus szerint ábécésorrendbe, azon belül pedig legénység szerint növekvőbe!
        public List<Starship> GetShipsOrderedByTypeThenCrew()
        {
            throw new NotImplementedException();
        }

        // 11. Feladat: Add vissza az 5 legidősebb (legrégebben szolgálatba állított) űrhajót!
        public List<Starship> GetTop5OldestShips()
        {
            throw new NotImplementedException();
        }

        // 12. Feladat: Hagyd figyelmen kívül az első 10 hajót, és add vissza a maradékot!
        public List<Starship> SkipFirstTenShips()
        {
            throw new NotImplementedException();
        }

        // 13. Feladat: Add vissza a hajók neveit és típusait egy formázott karakterlánc listában (pl. "Enterprise (Explorer)")!
        public List<string> GetShipNameAndTypeFormatted()
        {
            throw new NotImplementedException();
        }

        // 14. Feladat: Csoportosítsd a hajókat típusuk szerint! (Dictionary/Lookup vagy IGrouping)
        public IEnumerable<IGrouping<ShipType, Starship>> GetShipsGroupedByType()
        {
            throw new NotImplementedException();
        }

        // 15. Feladat: Kérdezd le, hogy típusonként hány darab űrhajó található a flottában!
        public Dictionary<ShipType, int> GetShipCountByType()
        {
            throw new NotImplementedException();
        }

        // 16. Feladat: Keresd meg a leggyorsabb Mining típusú űrhajót!
        public Starship GetFastestMiningShip()
        {
            throw new NotImplementedException();
        }

        // 17. Feladat: Add vissza azokat a hajókat, amelyek neve "SS"-sel kezdődik!
        public List<Starship> GetShipsStartingWithSS()
        {
            throw new NotImplementedException();
        }

        // 18. Feladat: Szűrd le azokat a hajókat, amelyeknél az aktív pajzs ellenére a legénység több mint 300 fő!
        public List<Starship> GetShieldedHeavyShips()
        {
            throw new NotImplementedException();
        }

        // 19. Feladat: Készíts egy névtelen objektumokból (vagy Tuple-ből) álló listát, ami csak a hajó azonosítóját (Id) és a szolgálati éveinek számát tartalmazza!
        public object GetShipAges()
        {
            throw new NotImplementedException();
        }

        // 20. Feladat: Válassz ki egy tetszőleges hajót, aminek a neve tartalmazza a "Voyager" szót. Ha nincs ilyen, adj vissza null értéket!
        public Starship GetVoyagerOrNull()
        {
            throw new NotImplementedException();
        }
    }
}