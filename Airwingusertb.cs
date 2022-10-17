using System;
using System.Collections.Generic;

namespace Airwing.Models
{
    public partial class Airwingusertb
    {
        public int Userid { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ContacNumber { get; set; }
        public string? Email { get; set; }
        public string Userloginid { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
