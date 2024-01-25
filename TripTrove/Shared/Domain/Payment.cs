using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripTrove.Shared.Domain
{
    public class Payment
    {
       public string? PaymentId {  get; set; }
        public string? PaymentMethod { get; set;}
        public string? PaymentDate { get; set;}
        public string? TransactionDetail { get; set;}
        public int? Amount { get; set;}
        public int TravellerId { get; set; }
        public int BookingId { get; set; }

    }
}
