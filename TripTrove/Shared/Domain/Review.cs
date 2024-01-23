using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripTrove.Shared.Domain
{
    public class Review
    {
        public int? reviewId {  get; set; }
        public int? rating { get; set; }
        public string? comments { get; set; }
        public string? datePosted { get; set; }
        public int? TravellerId { get; set;}
        public int? PreMadeTripId {  get; set; }
       
    }
}
