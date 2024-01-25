using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripTrove.Shared.Domain
{
    public class Booking
    {
        public int? BookingId {  get; set; }
        public int? PreMadeTripId { get; set; }
        public int? TravellerId { get; set;}
        public int? TravelAgentId { get; set;}
        public string? Status { get; set; }
        public string? CreatedAt { get; set; }
        public string? ModifiedAt { get; set;}
    }
}
