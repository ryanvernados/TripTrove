using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TripTrove.Shared.Domain;
using static Duende.IdentityServer.Models.IdentityResources;

namespace TripTrove.Server.Configurations.Entities
{
    public class PreMadeTripSeedConfiguration : IEntityTypeConfiguration<PreMadeTrip>

    {
        public void Configure(EntityTypeBuilder<PreMadeTrip> builder)
        {
            builder.HasData(
                new PreMadeTrip
                {
                    PreMadeTripId = 1,
                    TravelAgentId = 1,
                    Title = "Singapore tour",
                    Picture = "images/SG tour.jpg",
                    Description = "Enjoy the Lion City with a 4-day 3-night itinerary." +
                    "With exciting trips to outstanding destinations such as: Merlion statue, Marina Sands Bay, Chinatown",
                    Duration = "4days,3nights",
                    Price = "$199",
                    Itinery = "Day1 - Merlion Statue, Day2 - Singapore Zoo, Day3 - Marina Sands Bay, Day4 - Chinatown, Plaza Singapura",
                    Included = "Marina Bay Sands Hotel",
                    StartDates = new DateTime(2024, 2, 1),
                    EndDates = new DateTime(2024,2,5)
                },
                new PreMadeTrip
                {
                    PreMadeTripId = 2,
                    TravelAgentId = 1,
                    Title = "Paris tour",
                    Picture = "images/Paris Tour.jpeg",
                    Description ="With this Paris travel, marvel at the wrought-iron spire of the Eiffel Tower piercing the clouds, lamplit bridges spanning the Seine," +
                    " and art nouveau cafes spilling on to wicker-chair-lined terraces that are indelibly etched in the minds of anyone who visits the city.",
                    Duration = "3days,2nights",
                    Price = "$699",
                    Itinery = "Day1 - Eiffel Tower, Day2 - River Seine Cruise, Day3 - Illumination Tour",
                    Included = "Holiday Inn Paris Opera Grands Boulevards",
                    StartDates = new DateTime(2024, 5, 12),
                    EndDates = new DateTime(2024,5,15)
                },
                new PreMadeTrip
                {
                    PreMadeTripId = 3,
                    TravelAgentId = 2,
                    Title = "Italy tour",
                    Picture = "images/Italy Tour.jpeg",
                    Description = "Discover the Best of Italy, from the ancient treasures of Rome to Renaissance Florence and everything in between. " +
                    "Imagine staying overnight in a renovated Franciscan monastery in Assisi, lapping up the chic lifestyle on Capri.",
                    Duration = "5days,4nights",
                    Price = "$2499",
                    Itinery = "Day1 - Ancient Rome and the Vatican City, Day2 - Ruins of Pompeii and Sorrento, Day3 -  Isle of Capri, Day4 - St. Mark's and More in Venice, Day5 - Tower Of Pisa",
                    Included = "iH Hotels Roma Cicerone Rome/Una Hotel Rome,Johanna Park Hotel Sorrento,Grand Hotel Cesare Augusto,Hotel Cenacolo Assisi,Biasutti Hotel Venice Lido",
                    StartDates = new DateTime(2024, 8, 22),
                    EndDates = new DateTime(2024, 8, 27)
                },
                new PreMadeTrip
                {
                    PreMadeTripId = 4,
                    TravelAgentId = 3,
                    Title = "Japan tour",
                    Picture = "images/Japan Tour.jpeg",
                    Description = "We arrange fully customizable private tours of Japan, working with you to ensure that your experiences here are authentic, culturally enriching and of the highest quality." +
                    "Most importantly, they are yours alone, to enjoy at your own pace without the hassle of tour groups or total strangers.",
                    Duration = "2days,1night",
                    Price = "$899",
                    Itinery = "Day1 - Yanagawa Boat Ride, Day2 - Yufuin Floral Village",
                    Included = "Marina Bay Sands Hotel",
                    StartDates = new DateTime(2024, 12, 1),
                    EndDates = new DateTime(2024, 12, 2)
                }




                );
        }
    }
}
