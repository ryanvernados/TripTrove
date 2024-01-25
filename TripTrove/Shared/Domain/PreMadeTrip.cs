using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripTrove.Shared.Domain
{
    public class PreMadeTrip
    {
        public int PreMadeTripId { get; set; }
        public int TravelAgentId { get; set; }
        public string? Title { get; set; }
        public string? Picture { get; set; }
        public string? Description { get; set; }
        public string? Duration { get; set; }
        public string? Price { get; set; }
        public string? Itinery { get; set; }
        public string? Included { get; set; }
        public DateTime? StartDates { get; set; }
        public DateTime? EndDates { get; set; }



    }
}
