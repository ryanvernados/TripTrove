using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripTrove.Shared.Domain
{
    public class Activity
    {
        public int ActivityID { get; set; }
        public int TripId { get; set; }
        public virtual Trip? Trip { get; set; }
        public string Airline { get; set; }
        public DateTime DepatureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string DepatureAirport { get; set; }
        public string ArrivalAirport { get; set; }
        public string TicketNumber { get; set; }
        public string SeatNumber { get; set; }
        public double Cost { get; set; }
    }
}
