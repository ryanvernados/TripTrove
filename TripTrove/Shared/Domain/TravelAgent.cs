﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripTrove.Shared.Domain
{
    public class TravelAgent
    {
        public int TravelAgentId { get; set; }
        public string? Username { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int? ContactInfo {  get; set; }
        public int? DateJoined { get; set; }
        public string? ProfilePicture { get; set; }
    }
}
