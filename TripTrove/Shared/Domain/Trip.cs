using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripTrove.Shared.Domain
{
    public class Trip
    {
        public int TripId { get; set; }
        public int TravellerId1 { get; set; }
        public int TravellerId2 { get; set; }
        public int TravellerId3 { get; set; }
        public virtual Traveller? Traveller { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Destination { get; set; }
        public string Notes { get; set; }
        public DateTime DateCreated { get; set; }
        public string LastModified { get; set; }
    }
}
