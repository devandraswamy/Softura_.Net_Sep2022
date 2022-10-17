using System;
using System.Collections.Generic;

namespace Airwing.Models
{
    public partial class Flightdatatb
    {
        public int Fid { get; set; }
        public string Flightname { get; set; } = null!;
        public string Flightfrom { get; set; } = null!;
        public string Flightto { get; set; } = null!;
        public string FlightSeats { get; set; } = null!;
        public string FlightFare { get; set; } = null!;
    }
}
