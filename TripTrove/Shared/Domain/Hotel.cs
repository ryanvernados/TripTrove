using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripTrove.Shared.Domain
{
    public class Hotel
    {
        public int HotelId { get; set; }
        public virtual Trip? Trip { get; set; }
        public int TripId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string RoomType { get; set; }
        public string ReservationNumber { get; set; }
        public double Cost { get; set; }

    }
}
