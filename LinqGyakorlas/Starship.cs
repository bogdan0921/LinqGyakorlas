using System;

namespace LinqGyakorlas
{
    public enum ShipType
    {
        Explorer,
        Cargo,
        Fighter,
        Medical,
        Mining
    }

    public class Starship
    {
        // Privát adattagok
        private string _id;
        private string _name;
        private ShipType _type;
        private int _crewCount;
        private double _maxSpeed; // Warp/Fénysebesség szorzóban
        private bool _isShieldActive;
        private DateTime _commissionDate;

        // Nyilvános property-k
        public string Id => _id;
        public string Name => _name;
        public ShipType Type => _type;
        public int CrewCount => _crewCount;
        public double MaxSpeed => _maxSpeed;
        public bool IsShieldActive => _isShieldActive;
        public DateTime CommissionDate => _commissionDate;

        // Konstruktor
        public Starship(string id, string name, ShipType type, int crewCount, double maxSpeed, bool isShieldActive, DateTime commissionDate)
        {
            _id = id;
            _name = name;
            _type = type;
            _crewCount = crewCount;
            _maxSpeed = maxSpeed;
            _isShieldActive = isShieldActive;
            _commissionDate = commissionDate;
        }

        // ToString felülírás
        public override string ToString()
        {
            return $"[{_id}] {_name} ({_type}) - Legénység: {_crewCount} fő, Max sebesség: {_maxSpeed} Warp, Pajzs: {(_isShieldActive ? "Aktív" : "Inaktív")}, Hadseregbe állítva: {_commissionDate:yyyy.MM.dd}";
        }
    }
}