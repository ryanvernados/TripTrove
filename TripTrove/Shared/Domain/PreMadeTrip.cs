using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripTrove.Shared.Domain
{
    internal class PreMadeTrip
    {
        public int PreMadeTripId { get; set; }
        public int TravelAgentId { get; set; }
        public string? title { get; set; }
        public string? picture { get; set; }
        public string? description { get; set; }
        public int? duration { get; set; }
        public int? price { get; set; }
        public string? itinery { get; set; }
        public string? included { get; set; }
        public int? startDates { get; set; }
        public int? endDates { get; set;}



    }
}
