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
                    Title = "Okinawa,Japan tour",
                    Picture = "images/Japan Tour.jpeg",
                    Description = "We arrange fully customizable private tours of Japan, working with you to ensure that your experiences here are authentic, culturally enriching and of the highest quality." +
                    "Most importantly, they are yours alone, to enjoy at your own pace without the hassle of tour groups or total strangers.",
                    Duration = "2days,1night",
                    Price = "$899",
                    Itinery = "Day1 - Yanagawa Boat Ride, Day2 - Yufuin Floral Village",
                    Included = "Marina Bay Sands Hotel",
                    StartDates = new DateTime(2024, 12, 1),
                    EndDates = new DateTime(2024, 12, 2)
                },
                new PreMadeTrip
                {
                    PreMadeTripId = 5,
                    TravelAgentId = 3,
                    Title = "Shanghai,China tour",
                    Picture = "images/shanghai.jpg",
                    Description = "We will visit one of the most beautiful and modern places in China's eastern coast",
                    Duration = "2days,1night",
                    Price = "$240",
                    Itinery = "Day1 - Shanghai's city skyscrapers and museum, Day2 - Touring the Huanpu River",
                    Included = "Shanghai International Hotel",
                    StartDates = new DateTime(2024, 10, 11),
                    EndDates = new DateTime(2024, 10, 13)
                },
                new PreMadeTrip
                {
                    PreMadeTripId = 6,
                    TravelAgentId = 4,
                    Title = "Australia tour",
                    Picture = "images/Australia tour.jpeg",
                    Description = "",
                    Duration = "4days,3nights",
                    Price = "$2240",
                    Itinery = "Day1 - Vivonne Bay beach, Day2 - Ningaloo Reef, Day3 - Rottnest Island, Day4 - Great Barrier Reef",
                    Included = "Hilton Surfers Paradise Hotel, Sydney Boutique Hotel",
                    StartDates = new DateTime(2024, 10, 11),
                    EndDates = new DateTime(2024, 10, 13)
                },
                new PreMadeTrip
                {
                    PreMadeTripId = 7,
                    TravelAgentId = 2,
                    Title = "Indonesia honeymoon tour",
                    Picture = "images/indo tour.jpeg",
                    Description = "Your once-in-a-lifetime honeymoon journey starts at a private luxury villa near the southern tip of Bali, " +
                    "just minutes away from Seminyak Beach and within walking distance of lively, high-end shopping streets.",
                    Duration = "3days,2nights",
                    Price = "$1240",
                    Itinery = "Day1 - Morning Yoga session at Kupu Kupu Barong, Day2 - Private Guided sightseeing tour to Ubud and Kintamani, Day3 - Volcano Batur",
                    Included = "Hilton Surfers Paradise Hotel, Sydney Boutique Hotel",
                    StartDates = new DateTime(2024, 9, 11),
                    EndDates = new DateTime(2024, 9, 14)
                },
                new PreMadeTrip
                {
                    PreMadeTripId = 8,
                    TravelAgentId = 5,
                    Title = "Hanoi,Vietnam tour",
                    Picture = "images/viet tour.jpeg",
                    Description = "You will be inspired by stunning landscapes, exotic culture and friendly people in our Vietnam Tour, take time to visit the historical sights of Hanoi.",
                    Duration = "3days,2nights",
                    Price = "$969",
                    Itinery = "Day1 - Hanoi City Tour, Day2 - Ninh Binh, Day3 - Halong Bay",
                    Included = "Mayflower Hotel Hanoy, Solaria Hotel",
                    StartDates = new DateTime(2024, 5, 10),
                    EndDates = new DateTime(2024, 5, 13)
                },
                new PreMadeTrip
                {
                    PreMadeTripId = 9,
                    TravelAgentId = 3,
                    Title = "Disneyland Tokyo tour",
                    Picture = "images/Disney tour.jpeg",
                    Description = "A trip to the wonderful Disneyland Tokyo.",
                    Duration = "1day,0night",
                    Price = "$89",
                    Itinery = "Day1 - Disneyland Tokyo",
                    Included = "",
                    StartDates = new DateTime(2024, 9, 11),
                    EndDates = new DateTime(2024, 9, 14)
                },
                new PreMadeTrip
                {
                    PreMadeTripId = 10,
                    TravelAgentId = 1,
                    Title = "Turkey Tour",
                    Picture = "images/Disney tour.jpeg",
                    Description = "Travel Turkey on this 15-day guided tour. See Cappadocia, where golden landscapes give way to caverns below. " +
                    "You’ll descend into a local resident’s cave house for a tour and talk about their way of life. ",
                    Duration = "6days,5nights",
                    Price = "$3481",
                    Itinery = "Day1 - Landing on Istanbul, Day2 - Bosphorus Cruise and Bursa, Day3 - Cumalikizik and Gordion, Day4 - Sophisticated Ankara, Day5 - The Underground Cities of Cappadocia Experience, Day6 - Konya",
                    Included = "Grand Wyndham Levent,Mövenpick Bursa Hotel, Ankara HiltonSA, DoubleTree by Hilton Avanos, Novotel Konya Hotel",
                    StartDates = new DateTime(2024, 9, 11),
                    EndDates = new DateTime(2024, 9, 17)


                }


                );
        }
    }
}
