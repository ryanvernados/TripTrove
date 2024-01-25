using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripTrove.Shared.Domain
{
    public class Review
    {
        public int? ReviewId {  get; set; }
        public int? Rating { get; set; }
        public string? Comments { get; set; }
        public string? DatePosted { get; set; }
        public int? TravellerId { get; set;}
        public int? PreMadeTripId {  get; set; }
       
    }
}
