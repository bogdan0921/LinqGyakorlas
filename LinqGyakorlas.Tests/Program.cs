using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqGyakorlas.Tests
{
    [TestFixture]
    public class FleetManagerTests
    {
        private FleetManager _fleetManager;
        private List<Starship> _testShips;

        [SetUp]
        public void Setup()
        {
            // Kontrollált tesztadatok a pontos Assert elvárásokhoz
            _testShips = new List<Starship>
            {
                new Starship("S-01", "SS Voyager", ShipType.Explorer, 150, 9.5, true, new DateTime(2250, 1, 1)),
                new Starship("S-02", "Cargo Alpha", ShipType.Cargo, 10, 3.0, false, new DateTime(2150, 5, 10)),
                new Starship("S-03", "SS Titan", ShipType.Fighter, 50, 8.0, true, new DateTime(2280, 3, 15)),
                new Starship("S-04", "Deep Miner", ShipType.Mining, 400, 4.5, true, new DateTime(2300, 11, 20)),
                new Starship("S-05", "Big Transport", ShipType.Cargo, 1200, 2.0, false, new DateTime(2210, 8, 5)),
                new Starship("S-06", "Fast Miner", ShipType.Mining, 80, 6.0, false, new DateTime(2295, 2, 28))
            };

            _fleetManager = new FleetManager(_testShips);
        }

        [Test]
        public void GetFastShips_ReturnsShipsWithSpeedOverFive()
        {
            var result = _fleetManager.GetFastShips();

            Assert.That(result.Count, Is.EqualTo(3));
            Assert.That(result.All(s => s.MaxSpeed > 5.0), Is.True);
        }

        [Test]
        public void GetCargoShipNames_ReturnsOnlyCargoNames()
        {
            var result = _fleetManager.GetCargoShipNames();

            Assert.That(result, Is.EquivalentTo(new[] { "Cargo Alpha", "Big Transport" }));
        }

        [Test]
        public void GetActiveShieldCount_ReturnsCorrectCount()
        {
            var result = _fleetManager.GetActiveShieldCount();

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void HasShipWithLargeCrew_ReturnsTrueIfCrewOver1000()
        {
            var result = _fleetManager.HasShipWithLargeCrew();

            Assert.That(result, Is.True);
        }

        [Test]
        public void AreAllShipsModern_ReturnsFalse_WhenShipBefore2200Exists()
        {
            var result = _fleetManager.AreAllShipsModern();

            // S-02 2150-es kiadású, így hamisat kell adnia
            Assert.That(result, Is.False);
        }

        [Test]
        public void GetShipWithLargestCrew_ReturnsShipWith1200Crew()
        {
            var result = _fleetManager.GetShipWithLargestCrew();

            Assert.That(result.Id, Is.EqualTo("S-05"));
            Assert.That(result.CrewCount, Is.EqualTo(1200));
        }

        [Test]
        public void GetTotalCrewCount_CalculatesCorrectSum()
        {
            var result = _fleetManager.GetTotalCrewCount();

            // 150 + 10 + 50 + 400 + 1200 + 80 = 1890
            Assert.That(result, Is.EqualTo(1890));
        }

        [Test]
        public void GetAverageExplorerSpeed_ReturnsCorrectAverage()
        {
            var result = _fleetManager.GetAverageExplorerSpeed();

            Assert.That(result, Is.EqualTo(9.5));
        }

        [Test]
        public void GetShipsOrderedBySpeedDescending_ReturnsCorrectOrder()
        {
            var result = _fleetManager.GetShipsOrderedBySpeedDescending();

            Assert.That(result.First().MaxSpeed, Is.EqualTo(9.5));
            Assert.That(result.Last().MaxSpeed, Is.EqualTo(2.0));
        }

        [Test]
        public void GetShipsOrderedByTypeThenCrew_OrdersCorrectly()
        {
            var result = _fleetManager.GetShipsOrderedByTypeThenCrew();

            // Első típus a Cargo, azon belül 10 fő < 1200 fő
            Assert.That(result.First().Id, Is.EqualTo("S-02"));
            Assert.That(result[1].Id, Is.EqualTo("S-05"));
        }

        [Test]
        public void GetTop5OldestShips_ReturnsOldestFive()
        {
            var result = _fleetManager.GetTop5OldestShips();

            Assert.That(result.Count, Is.EqualTo(5));
            Assert.That(result.First().CommissionDate.Year, Is.EqualTo(2150));
            Assert.That(result.Any(s => s.Id == "S-04"), Is.False); // A legújabb 2300-as nem fér be az első 5-be
        }

        [Test]
        public void SkipFirstTenShips_ReturnsEmpty_WhenLessThanTenShips()
        {
            var result = _fleetManager.SkipFirstTenShips();

            Assert.That(result, Is.Empty);
        }

        [Test]
        public void GetShipNameAndTypeFormatted_FormatsStringsCorrectly()
        {
            var result = _fleetManager.GetShipNameAndTypeFormatted();

            Assert.That(result.First(), Is.EqualTo("SS Voyager (Explorer)"));
        }

        [Test]
        public void GetShipsGroupedByType_GroupsAllTypes()
        {
            var result = _fleetManager.GetShipsGroupedByType();

            Assert.That(result.Count(), Is.EqualTo(4)); // Explorer, Cargo, Fighter, Mining
        }

        [Test]
        public void GetShipCountByType_ReturnsCorrectDictionary()
        {
            var result = _fleetManager.GetShipCountByType();

            Assert.That(result[ShipType.Cargo], Is.EqualTo(2));
            Assert.That(result[ShipType.Mining], Is.EqualTo(2));
            Assert.That(result[ShipType.Explorer], Is.EqualTo(1));
        }

        [Test]
        public void GetFastestMiningShip_ReturnsFastMiner()
        {
            var result = _fleetManager.GetFastestMiningShip();

            Assert.That(result.Id, Is.EqualTo("S-06"));
            Assert.That(result.MaxSpeed, Is.EqualTo(6.0));
        }

        [Test]
        public void GetShipsStartingWithSS_ReturnsOnlyMatchingShips()
        {
            var result = _fleetManager.GetShipsStartingWithSS();

            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result.All(s => s.Name.StartsWith("SS")), Is.True);
        }

        [Test]
        public void GetShieldedHeavyShips_ReturnsActiveShieldAndCrewOver300()
        {
            var result = _fleetManager.GetShieldedHeavyShips();

            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result.First().Id, Is.EqualTo("S-04"));
        }

        [Test]
        public void GetShipAges_CalculatesYearsInServiceCorrectly()
        {
            var result = _fleetManager.GetShipAges();

            int expectedAgeVoyager = DateTime.Now.Year - 2250;
            var voyagerAge = result.First(r => r.Id == "S-01").YearsInService;

            Assert.That(voyagerAge, Is.EqualTo(expectedAgeVoyager));
        }

        [Test]
        public void GetVoyagerOrNull_ReturnsVoyagerWhenPresent()
        {
            var result = _fleetManager.GetVoyagerOrNull();

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Name, Is.EqualTo("SS Voyager"));
        }
    }
}