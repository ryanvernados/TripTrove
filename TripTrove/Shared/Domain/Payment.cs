using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripTrove.Shared.Domain
{
    internal class Payment
    {
       public string? paymentId {  get; set; }
        public string? paymentMethod { get; set;}
        public string? paymentDate { get; set;}
        public string? transactionDetail { get; set;}
        public int? amount { get; set;}
        public int TravellerId { get; set; }
        public int BookingId { get; set; }

    }
}
