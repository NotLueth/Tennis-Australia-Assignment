using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TennisAustraliaAssignment.Data;

namespace TennisAustraliaAssignment.Models
{
    public static class SeedData 
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TennisContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TennisContext>>()))
            {
                //Check age bracket if it has data
                if (context.AgeBracket.Any())
                {
                    return;// return because information exists
                }
                context.AgeBracket.AddRange(
                    new AgeBracket
                    {
                        AgeBracketName = "Children(U/10)",
                        AgeBracketDescription = "Children with ages of 10 and under"
                    },
                    new AgeBracket
                    {
                        AgeBracketName = "Juniors(10 - 11)",
                        AgeBracketDescription = "Children with ages 10 - 11"
                    },

                    new AgeBracket
                    {
                        AgeBracketName = "Advance Juniors(11-13)",
                        AgeBracketDescription = "Children with ages of 11 - 13"

                    },

                    new AgeBracket
                    {
                        AgeBracketName = "Junior Teens(13 - 15)",
                        AgeBracketDescription = "Teenagers with ages 13 - 15"
                    },

                    new AgeBracket
                    {
                        AgeBracketName = "Intermediate Teens(15-16)",
                        AgeBracketDescription = "Teenagers with ages of 15 - 16"

                    },

                    new AgeBracket
                    {
                        AgeBracketName = "Advance Teens(16 - 17)",
                        AgeBracketDescription = "Teenagers with ages 16 - 17"
                    },

                    new AgeBracket
                    {
                        AgeBracketName = "Adults(18+)",
                        AgeBracketDescription = "Asults with ages of 18 and above"

                    },

                    new AgeBracket
                    {
                        AgeBracketName = "Seniors(35+)",
                        AgeBracketDescription = "Adults with ages above 35"
                    },

                    new AgeBracket
                    {
                        AgeBracketName = "Senior Adults(65+)",
                        AgeBracketDescription = "Adults with ages above 65"
                    }
                    ); context.SaveChanges();

                //Check Players if it has data
                if (context.Players.Any())
                {
                    return;// return because information exists
                }

                context.Players.AddRange(
                    new Player {
                        TennisMembershipNumber = 1234,
                        AustralianRanking = 1,
                        UniversalTennisRating = 1,
                        FirstName = "Roger",
                        LastName = "Michael",
                        Age = 20,
                        Street = "108 Birch Street",
                        City = "Sydney",
                        Postcode = 2000,
                        Email = "RogerM@gmail.com",
                        Phone = "0433776883"
                    },
                    new Player
                    {
                        TennisMembershipNumber = 12245,
                        AustralianRanking = 2,
                        UniversalTennisRating = 2,
                        FirstName = "Jessica",
                        LastName = "yarn",
                        Age = 24,
                        Street = "111 james Street",
                        City = "Melbourne",
                        Postcode = 3001,
                        Email = "Jess@gmail.com",
                        Phone = "0422476883"
                    },
                    new Player
                    {
                        TennisMembershipNumber = 12785,
                        AustralianRanking = 3,
                        UniversalTennisRating = 3,
                        FirstName = "Jim",
                        LastName = "Ron",
                        Age = 19,
                        Street = "10 Funk ave",
                        City = "Perth",
                        Postcode = 6000,
                        Email = "cantstopjim@gmail.com",
                        Phone = "0422776223"
                    },
                    new Player
                    {
                        TennisMembershipNumber = 11115,
                        AustralianRanking = 4,
                        UniversalTennisRating = 4,
                        FirstName = "Jai",
                        LastName = "Davis",
                        Age = 33,
                        Street = "12 james Street",
                        City = "Melbourne",
                        Postcode = 3338,
                        Email = "JJman@gmail.com",
                        Phone = "0435866883"
                    },
                    new Player
                    {
                        TennisMembershipNumber = 12344,
                        AustralianRanking = 5,
                        UniversalTennisRating = 5,
                        FirstName = "Luke",
                        LastName = "bogger",
                        Age = 27,
                        Street = "1 faker Street",
                        City = "Melbourne",
                        Postcode = 3322,
                        Email = "Lukey@gmail.com",
                        Phone = "0431236883"
                    },
                    new Player
                    {
                        TennisMembershipNumber = 12245,
                        AustralianRanking = 6,
                        UniversalTennisRating = 6,
                        FirstName = "Nick",
                        LastName = "Ralf",
                        Age = 18,
                        Street = "55 Owl Street",
                        City = "Melbounre",
                        Postcode = 2000,
                        Email = "Woof@gmail.com",
                        Phone = "0433771113"
                    },
                    new Player
                    {
                        TennisMembershipNumber = 12366,
                        AustralianRanking = 7,
                        UniversalTennisRating = 7,
                        FirstName = "Brent",
                        LastName = "massiv",
                        Age = 29,
                        Street = "300 wonder Street",
                        City = "Melbourne",
                        Postcode = 3331,
                        Email = "brento@gmail.com",
                        Phone = "0433677883"
                    },
                    new Player
                    {
                        TennisMembershipNumber = 17745,
                        AustralianRanking = 8,
                        UniversalTennisRating = 8,
                        FirstName = "Roger",
                        LastName = "Burnout",
                        Age = 20,
                        Street = "109 Birch Street",
                        City = "Sydney",
                        Postcode = 2000,
                        Email = "Realroger@gmail.com",
                        Phone = "0433796883"
                    },
                    new Player
                    {
                        TennisMembershipNumber = 19345,
                        AustralianRanking = 9,
                        UniversalTennisRating = 9,
                        FirstName = "Michael",
                        LastName = "Freedom",
                        Age = 25,
                        Street = "1 Birch Street",
                        City = "Sydney",
                        Postcode = 2000,
                        Email = "freedom@gmail.com",
                        Phone = "0422666883"
                    }
                    );
                context.SaveChanges();

                //Check Organisers bracket if it has data
                if (context.Organisers.Any())
                {
                    return;// return because information exists
                }
                context.Organisers.AddRange(
                    new Organiser
                    {
                        StartDate = DateTime.Parse("2019-10-12"),
                        FirstName = "John",
                        LastName = "Freedom",
                        Age = 45,
                        Street = "10 roge Street",
                        City = "Sydney",
                        Postcode = 2000,
                        Email = "Free@gmail.com",
                        Phone = "0422777883"
                    },
                    new Organiser
                    {
                        StartDate = DateTime.Parse("2018-11-11"),
                        FirstName = "Michael",
                        LastName = "Job",
                        Age = 55,
                        Street = "1 bomb Street",
                        City = "Sydney",
                        Postcode = 2000,
                        Email = "joboman@gmail.com",
                        Phone = "0422226883"
                    },
                    new Organiser
                    {
                        StartDate = DateTime.Parse("2019-10-12"),
                        FirstName = "Michael",
                        LastName = "NotFree",
                        Age = 25,
                        Street = "2 Birch Street",
                        City = "Sydney",
                        Postcode = 2000,
                        Email = "notFree@gmail.com",
                        Phone = "0411333441"
                    },
                    new Organiser
                    {
                        StartDate = DateTime.Parse("2019-10-12"),
                        FirstName = "John",
                        LastName = "Freedom",
                        Age = 33,
                        Street = "8 Birch Street",
                        City = "Sydney",
                        Postcode = 2000,
                        Email = "countdown@gmail.com",
                        Phone = "0422616883"
                    },
                    new Organiser
                    {
                        StartDate = DateTime.Parse("2001-01-02"),
                        FirstName = "Jay",
                        LastName = "Student",
                        Age = 70,
                        Street = "99 helpme Street",
                        City = "Melbourne",
                        Postcode = 3000,
                        Email = "saveme@gmail.com",
                        Phone = "0432116883"
                    },
                    new Organiser
                    {
                        StartDate = DateTime.Parse("2020-11-11"),
                        FirstName = "Easter",
                        LastName = "Eggo",
                        Age = 18,
                        Street = "1 easter Street",
                        City = "Melbourne",
                        Postcode = 3000,
                        Email = "Easteregg@gmail.com",
                        Phone = "0411111111"
                    },
                    new Organiser
                    {
                        StartDate = DateTime.Parse("2012-07-12"),
                        FirstName = "Freddy",
                        LastName = "Fanman",
                        Age = 32,
                        Street = "22 ron Street",
                        City = "Melbourne",
                        Postcode = 3033,
                        Email = "thishastostop@gmail.com",
                        Phone = "0422111333"
                    },
                    new Organiser
                    {
                        StartDate = DateTime.Parse("2005-09-10"),
                        FirstName = "Biden",
                        LastName = "Trump",
                        Age = 66,
                        Street = "77 White Street",
                        City = "Sydney",
                        Postcode = 2000,
                        Email = "Trumpb@gmail.com",
                        Phone = "0466666783"
                    },
                    new Organiser
                    {
                        StartDate = DateTime.Parse("2019-10-12"),
                        FirstName = "Nick",
                        LastName = "binmop",
                        Age = 44,
                        Street = "111 freed Street",
                        City = "Sydney",
                        Postcode = 2000,
                        Email = "binmop@gmail.com",
                        Phone = "0411661183"
                    }
                    );

                context.SaveChanges();

                //Check Registrations if it has data
                if (context.registrations.Any())
                {
                    return;// return because information exists
                }

                context.registrations.AddRange(
                    new Registration
                    {
                        RegistrationSignDate = DateTime.Parse("2011-09-01")
                    },
                    new Registration
                    {
                        RegistrationSignDate = DateTime.Parse("2012-08-09")
                    },
                    new Registration
                    {
                        RegistrationSignDate = DateTime.Parse("2013-07-02")
                    },
                    new Registration
                    {
                        RegistrationSignDate = DateTime.Parse("2014-06-08")
                    },
                    new Registration
                    {
                        RegistrationSignDate = DateTime.Parse("2015-05-03")
                    },
                    new Registration
                    {
                        RegistrationSignDate = DateTime.Parse("2016-04-07")
                    },
                    new Registration
                    {
                        RegistrationSignDate = DateTime.Parse("2017-03-04")
                    },
                    new Registration
                    {
                        RegistrationSignDate = DateTime.Parse("2018-02-06")
                    },
                    new Registration
                    {
                        RegistrationSignDate = DateTime.Parse("2019-01-05")
                    }
                    );

                context.SaveChanges();

                //Check registration details if it has data
                if (context.RegistrationDetails.Any())
                {
                    return;// return because information exists
                }
                context.RegistrationDetails.AddRange(
                    new RegistrationDetails
                    {
                        RegistrationID = 1,
                        PlayerPersonalID = 9
                    },
                    new RegistrationDetails
                    {
                        RegistrationID = 2,
                        PlayerPersonalID = 8
                    },
                    new RegistrationDetails
                    {
                        RegistrationID = 3,
                        PlayerPersonalID = 7
                    },
                    new RegistrationDetails
                    {
                        RegistrationID = 4,
                        PlayerPersonalID = 6
                    },
                    new RegistrationDetails
                    {
                        RegistrationID = 5,
                        PlayerPersonalID = 5
                    },
                    new RegistrationDetails
                    {
                        RegistrationID = 6,
                        PlayerPersonalID = 4
                    },
                    new RegistrationDetails
                    {
                        RegistrationID = 7,
                        PlayerPersonalID = 3
                    },
                    new RegistrationDetails
                    {
                        RegistrationID = 8,
                        PlayerPersonalID = 2
                    },
                    new RegistrationDetails
                    {
                        RegistrationID = 9,
                        PlayerPersonalID = 1
                    }
                    );

                context.SaveChanges();

                //Check tournament types if it has data
                if (context.TournamentTypes.Any())
                {
                    return;// return because information exists
                }
                context.TournamentTypes.AddRange(
                    new TournamentType
                    {
                        TournamentTypeName = "AMT",
                        TournamentTypeDescription = "AMT is a tournament with prize money associated with it"
                    },
                    new TournamentType
                    {
                        TournamentTypeName = "JRN",
                        TournamentTypeDescription = "JRN is a tournament That is made for Juniors"
                    },
                    new TournamentType
                    {
                        TournamentTypeName = "AMT-JRN",
                        TournamentTypeDescription = "AMT is a tournament with prize money associated with it for Juniors"
                    },
                    new TournamentType
                    {
                        TournamentTypeName = "ADLT",
                        TournamentTypeDescription = "ADLT is a tournament That is made for Adults only"
                    },
                    new TournamentType
                    {
                        TournamentTypeName = "ADLT-AMT",
                        TournamentTypeDescription = "AMT is a tournament with prize money associated with it for Adults"
                    },
                    new TournamentType
                    {
                        TournamentTypeName = "Teen",
                        TournamentTypeDescription = "Teen is a tournament That is made for Teens"
                    },
                    new TournamentType
                    {
                        TournamentTypeName = "Teen-AMT",
                        TournamentTypeDescription = "AMT is a tournament with prize money associated with it for Teens"
                    },
                    new TournamentType
                    {
                        TournamentTypeName = "18U-AMT",
                        TournamentTypeDescription = "18U is a tournament with prize money associated with it for those under 18"
                    },
                    new TournamentType
                    {
                        TournamentTypeName = "18U",
                        TournamentTypeDescription = "18U is a tournament That is made for those under 18"
                    }
                    );
                context.SaveChanges();

                //Check league rating if it has data
                if (context.LeagueRatings.Any())
                {
                    return;// return because information exists
                }

                context.LeagueRatings.AddRange(
                    new LeagueRating
                    {
                        LeagueName = "Bronze"
                    },
                    new LeagueRating
                    {
                        LeagueName = "Silver"
                    },
                    new LeagueRating
                    {
                        LeagueName = "Gold"
                    },
                    new LeagueRating
                    {
                        LeagueName = "Platinum"
                    },
                    new LeagueRating
                    {
                        LeagueName = "Diamond"
                    },
                    new LeagueRating
                    {
                        LeagueName = "Masters"
                    },
                    new LeagueRating
                    {
                        LeagueName = "GrandMasters"
                    },
                    new LeagueRating
                    {
                        LeagueName = "Challenger"
                    },
                    new LeagueRating
                    {
                        LeagueName = "WorldsFinest"
                    }
                    );
                context.SaveChanges();

                //Check surface if it has data
                if (context.Surface.Any())
                {
                    return;// return because information exists
                }
                context.Surface.AddRange(
                    new Surface
                    {
                        SurfaceName = "Hard",
                        SurfaceDescription = "Typical ball to ground resistance is little to none on field"
                    },
                    new Surface
                    {
                        SurfaceName = "Soft",
                        SurfaceDescription = "Typical ball to ground resistance is strong on field"
                    },
                    new Surface
                    {
                        SurfaceName = "Hard-Soft",
                        SurfaceDescription = "Typical ball to ground resistance is dependent on tempurture on field"
                    },
                    new Surface
                    {
                        SurfaceName = "Various",
                        SurfaceDescription = "Field could either be hard or soft and can change during the game"
                    },
                    new Surface
                    {
                        SurfaceName = "wacky",
                        SurfaceDescription = "Typical ball does not follow physics"
                    },
                    new Surface
                    {
                        SurfaceName = "wet",
                        SurfaceDescription = "Field is in a water field and is basically impossible to play in"
                    },
                    new Surface
                    {
                        SurfaceName = "Moon",
                        SurfaceDescription = "No gravity Field, typcially not done these days"
                    },
                    new Surface
                    {
                        SurfaceName = "5D Field",
                        SurfaceDescription = "Involves a lot of dimensional rifts, very tricky to master"
                    },
                    new Surface
                    {
                        SurfaceName = "Vintage",
                        SurfaceDescription = "Old style tennis with old style rules"
                    }
                    );
                context.SaveChanges();

                //Check venue if it has data
                if (context.Venue.Any())
                {
                    return;// return because information exists
                }

                context.Venue.AddRange(
                    new Venue {
                        VenueName = "Melbourne Arena",
                        Street = "180 Lonsdale street",
                        City = "Melbourne",
                        State = "VIC",
                        SurfaceID = 1,
                    },
                    new Venue
                    {
                        VenueName = "Sydney Arena",
                        Street = "10 Sydeny street",
                        City = "Sydney",
                        State = "NSW",
                        SurfaceID = 2,
                    },
                    new Venue
                    {
                        VenueName = "Perth Arena",
                        Street = "180 Perth street",
                        City = "Perth",
                        State = "WA",
                        SurfaceID = 1,
                    },
                    new Venue
                    {
                        VenueName = "Hobart Arena",
                        Street = "200 Tas street",
                        City = "Hobart",
                        State = "TAS",
                        SurfaceID = 2,
                    },
                    new Venue
                    {
                        VenueName = "Queens Arena",
                        Street = "120 fisher street",
                        City = "Brisbane",
                        State = "QLD",
                        SurfaceID = 1,
                    },
                    new Venue
                    {
                        VenueName = "Darwin Arena",
                        Street = "22 Darn street",
                        City = "Darwin",
                        State = "NT",
                        SurfaceID = 2,
                    },
                    new Venue
                    {
                        VenueName = "Southern Arena",
                        Street = "166 south street",
                        City = "Adelaide",
                        State = "SA",
                        SurfaceID = 1,
                    },
                    new Venue
                    {
                        VenueName = "ACT Arena",
                        Street = "170 Gov street",
                        City = "Canberra",
                        State = "ACT",
                        SurfaceID = 2,
                    },
                    new Venue
                    {
                        VenueName = "Melbourne backyard Arena",
                        Street = "123 fake street",
                        City = "Melbourne",
                        State = "VIC",
                        SurfaceID = 2,
                    }
                    );
                context.SaveChanges();

                //Check tournaments if it has data
                if (context.Tournaments.Any())
                {
                    return;// return because information exists
                }

                context.Tournaments.AddRange(
                    new Tournament
                    {
                        TournamentName = "Melbourne Bash",
                        Qualifier = "No",
                        StartDate = DateTime.Parse("2021-10-12"),
                        EndDate = DateTime.Parse("2021-11-12"),
                        SingupStartDate = DateTime.Parse("2021-01-01"),
                        SingupEndDate = DateTime.Parse("2021-02-02"),
                        PrizeMoney = 1000,
                        VenueID = 1,
                        TournamentTypeID = 1,
                        OrganiserPersonalID = 10
                    },
                    new Tournament
                    {
                        TournamentName = "Sydney Bash",
                        Qualifier = "No",
                        StartDate = DateTime.Parse("2022-10-12"),
                        EndDate = DateTime.Parse("2022-11-12"),
                        SingupStartDate = DateTime.Parse("2022-01-01"),
                        SingupEndDate = DateTime.Parse("2022-02-02"),
                        PrizeMoney = 1000,
                        VenueID = 2,
                        TournamentTypeID = 1,
                        OrganiserPersonalID = 11
                    },
                    new Tournament
                    {
                        TournamentName = "Perth Bash",
                        Qualifier = "No",
                        StartDate = DateTime.Parse("2019-10-12"),
                        EndDate = DateTime.Parse("2019-11-12"),
                        SingupStartDate = DateTime.Parse("2019-01-01"),
                        SingupEndDate = DateTime.Parse("2019-02-02"),
                        PrizeMoney = 1000,
                        VenueID = 3,
                        TournamentTypeID = 1,
                        OrganiserPersonalID = 12
                    },
                    new Tournament
                    {
                        TournamentName = "Hobart Bash",
                        Qualifier = "No",
                        StartDate = DateTime.Parse("2023-10-12"),
                        EndDate = DateTime.Parse("2023-11-12"),
                        SingupStartDate = DateTime.Parse("2021-01-01"),
                        SingupEndDate = DateTime.Parse("2023-02-02"),
                        PrizeMoney = 2000,
                        VenueID = 4,
                        TournamentTypeID = 1,
                        OrganiserPersonalID = 13
                    },
                    new Tournament
                    {
                        TournamentName = "Queensland Bash",
                        Qualifier = "No",
                        StartDate = DateTime.Parse("2022-05-05"),
                        EndDate = DateTime.Parse("2022-05-05"),
                        SingupStartDate = DateTime.Parse("2021-07-01"),
                        SingupEndDate = DateTime.Parse("2022-03-02"),
                        PrizeMoney = 1000,
                        VenueID = 5,
                        TournamentTypeID = 1,
                        OrganiserPersonalID = 14
                    },
                    new Tournament
                    {
                        TournamentName = "Darwin Bash",
                        Qualifier = "No",
                        StartDate = DateTime.Parse("2023-10-12"),
                        EndDate = DateTime.Parse("2023-11-12"),
                        SingupStartDate = DateTime.Parse("2022-01-01"),
                        SingupEndDate = DateTime.Parse("2022-02-02"),
                        PrizeMoney = 1000,
                        VenueID = 6,
                        TournamentTypeID = 1,
                        OrganiserPersonalID = 15
                    },
                    new Tournament
                    {
                        TournamentName = "South Bash",
                        Qualifier = "No",
                        StartDate = DateTime.Parse("2027-10-12"),
                        EndDate = DateTime.Parse("2027-11-12"),
                        SingupStartDate = DateTime.Parse("2026-01-01"),
                        SingupEndDate = DateTime.Parse("2026-02-02"),
                        PrizeMoney = 1000,
                        VenueID = 7,
                        TournamentTypeID = 1,
                        OrganiserPersonalID = 16
                    },
                    new Tournament
                    {
                        TournamentName = "ACT Bash",
                        Qualifier = "No",
                        StartDate = DateTime.Parse("2021-04-02"),
                        EndDate = DateTime.Parse("2021-07-02"),
                        SingupStartDate = DateTime.Parse("2021-01-01"),
                        SingupEndDate = DateTime.Parse("2021-02-02"),
                        PrizeMoney = 7888,
                        VenueID = 8,
                        TournamentTypeID = 1,
                        OrganiserPersonalID = 17
                    },
                    new Tournament
                    {
                        TournamentName = "Melbourne backyard Bash",
                        Qualifier = "No",
                        StartDate = DateTime.Parse("2021-10-12"),
                        EndDate = DateTime.Parse("2021-11-12"),
                        SingupStartDate = DateTime.Parse("2021-10-01"),
                        SingupEndDate = DateTime.Parse("2021-10-12"),
                        PrizeMoney = 0,
                        VenueID = 9,
                        TournamentTypeID = 2,
                        OrganiserPersonalID = 18
                    }

                    );

                context.SaveChanges();

                //Check tournament bracket if it has data
                if (context.TournamentBrackets.Any())
                {
                    return;// return because information exists
                }

                context.TournamentBrackets.AddRange(
                    new TournamentBracket
                    {
                        TournamentID = 1,
                        AgeBracketID = 7,
                        LeagueRatingLeagueID = 1
                    },
                    new TournamentBracket
                    {
                        TournamentID = 1,
                        AgeBracketID = 1,
                        LeagueRatingLeagueID = 1
                    },
                    new TournamentBracket
                    {
                        TournamentID = 1,
                        AgeBracketID = 2,
                        LeagueRatingLeagueID = 1
                    },
                    new TournamentBracket
                    {
                        TournamentID = 1,
                        AgeBracketID = 3,
                        LeagueRatingLeagueID = 1
                    },
                    new TournamentBracket
                    {
                        TournamentID = 1,
                        AgeBracketID = 4,
                        LeagueRatingLeagueID = 1
                    },
                    new TournamentBracket
                    {
                        TournamentID = 1,
                        AgeBracketID = 5,
                        LeagueRatingLeagueID = 1
                    },
                    new TournamentBracket
                    {
                        TournamentID = 1,
                        AgeBracketID = 6,
                        LeagueRatingLeagueID = 1
                    },
                    new TournamentBracket
                    {
                        TournamentID = 1,
                        AgeBracketID = 8,
                        LeagueRatingLeagueID = 1
                    },
                    new TournamentBracket
                    {
                        TournamentID = 1,
                        AgeBracketID = 9,
                        LeagueRatingLeagueID = 1
                    }
                    );
                context.SaveChanges();

                //Check matches if it has data
                if (context.Matches.Any())
                {
                    return;// return because information exists
                }

                context.Matches.AddRange(
                    new Match
                    {
                        Round = 1,
                        TournamentBracketID = 1,
                        FirstRegistrationID = 1,
                        SecondRegistrationID = 2,
                    },
                    new Match
                    {
                        Round = 1,
                        TournamentBracketID = 1,
                        FirstRegistrationID = 3,
                        SecondRegistrationID = 4,
                    },
                    new Match
                    {
                        Round = 1,
                        TournamentBracketID = 1,
                        FirstRegistrationID = 5,
                        SecondRegistrationID = 6,
                    },
                    new Match
                    {
                        Round = 2,
                        TournamentBracketID = 1,
                        FirstRegistrationID = 7,
                        SecondRegistrationID = 8,
                    },
                    new Match
                    {
                        Round = 2,
                        TournamentBracketID = 1,
                        FirstRegistrationID = 1,
                        SecondRegistrationID = 3,
                    },
                    new Match
                    {
                        Round = 2,
                        TournamentBracketID = 1,
                        FirstRegistrationID = 5,
                        SecondRegistrationID = 7,
                    },
                    new Match
                    {
                        Round = 3,
                        TournamentBracketID = 1,
                        FirstRegistrationID = 1,
                        SecondRegistrationID = 5,
                    },
                    new Match
                    {
                        Round = 3,
                        TournamentBracketID = 1,
                        FirstRegistrationID = 7,
                        SecondRegistrationID = 9,
                    },
                    new Match
                    {
                        Round = 4,
                        TournamentBracketID = 1,
                        FirstRegistrationID = 1,
                        SecondRegistrationID = 7,
                    }
                    );
                context.SaveChanges();

                //Check set results if it has data
                if (context.setResults.Any())
                {
                    return;// return because information exists
                }

                context.setResults.AddRange(
                    new SetResult
                    {
                        set = 1,
                        FirstRegIDScore = 45,
                        SecondRegIDScore = 0,
                        MatchID = 1
                    },
                    new SetResult
                    {
                        set = 2,
                        FirstRegIDScore = 45,
                        SecondRegIDScore = 0,
                        MatchID = 1
                    },
                    new SetResult
                    {
                        set = 3,
                        FirstRegIDScore = 45,
                        SecondRegIDScore = 0,
                        MatchID = 1
                    },
                    new SetResult
                    {
                        set = 4,
                        FirstRegIDScore = 45,
                        SecondRegIDScore = 0,
                        MatchID = 1
                    },


                    new SetResult
                    {
                        set = 1,
                        FirstRegIDScore = 45,
                        SecondRegIDScore = 0,
                        MatchID = 2
                    },
                    new SetResult
                    {
                        set = 2,
                        FirstRegIDScore = 45,
                        SecondRegIDScore = 0,
                        MatchID = 2
                    },
                    new SetResult
                    {
                        set = 3,
                        FirstRegIDScore = 45,
                        SecondRegIDScore = 0,
                        MatchID = 2
                    },
                    new SetResult
                    {
                        set = 4,
                        FirstRegIDScore = 45,
                        SecondRegIDScore = 0,
                        MatchID = 2
                    },

                    new SetResult
                    {
                        set = 1,
                        FirstRegIDScore = 45,
                        SecondRegIDScore = 0,
                        MatchID = 3
                    },
                    new SetResult
                    {
                        set = 2,
                        FirstRegIDScore = 45,
                        SecondRegIDScore = 0,
                        MatchID = 3
                    },
                    new SetResult
                    {
                        set = 3,
                        FirstRegIDScore = 45,
                        SecondRegIDScore = 0,
                        MatchID = 3
                    },
                    new SetResult
                    {
                        set = 4,
                        FirstRegIDScore = 45,
                        SecondRegIDScore = 0,
                        MatchID = 3
                    },

                    new SetResult
                    {
                        set = 1,
                        FirstRegIDScore = 45,
                        SecondRegIDScore = 0,
                        MatchID = 4
                    },
                    new SetResult
                    {
                        set = 2,
                        FirstRegIDScore = 45,
                        SecondRegIDScore = 0,
                        MatchID = 4
                    },
                    new SetResult
                    {
                        set = 3,
                        FirstRegIDScore = 45,
                        SecondRegIDScore = 0,
                        MatchID = 4
                    },
                    new SetResult
                    {
                        set = 4,
                        FirstRegIDScore = 45,
                        SecondRegIDScore = 0,
                        MatchID = 4
                    },
                    new SetResult
                    {
                        set = 1,
                        FirstRegIDScore = 45,
                        SecondRegIDScore = 0,
                        MatchID = 5
                    },
                    new SetResult
                    {
                        set = 2,
                        FirstRegIDScore = 45,
                        SecondRegIDScore = 0,
                        MatchID = 5
                    },
                    new SetResult
                    {
                        set = 3,
                        FirstRegIDScore = 45,
                        SecondRegIDScore = 0,
                        MatchID = 5
                    },
                    new SetResult
                    {
                        set = 4,
                        FirstRegIDScore = 45,
                        SecondRegIDScore = 0,
                        MatchID = 5
                    },
                    new SetResult
                    {
                        set = 1,
                        FirstRegIDScore = 45,
                        SecondRegIDScore = 0,
                        MatchID = 6
                    },
                    new SetResult
                    {
                        set = 2,
                        FirstRegIDScore = 45,
                        SecondRegIDScore = 0,
                        MatchID = 6
                    },
                    new SetResult
                    {
                        set = 3,
                        FirstRegIDScore = 45,
                        SecondRegIDScore = 0,
                        MatchID = 6
                    },
                    new SetResult
                    {
                        set = 4,
                        FirstRegIDScore = 45,
                        SecondRegIDScore = 0,
                        MatchID = 6
                    },
                    new SetResult
                    {
                        set = 1,
                        FirstRegIDScore = 45,
                        SecondRegIDScore = 0,
                        MatchID = 7
                    },
                    new SetResult
                    {
                        set = 2,
                        FirstRegIDScore = 45,
                        SecondRegIDScore = 0,
                        MatchID = 7
                    },
                    new SetResult
                    {
                        set = 3,
                        FirstRegIDScore = 45,
                        SecondRegIDScore = 0,
                        MatchID = 7
                    },
                    new SetResult
                    {
                        set = 4,
                        FirstRegIDScore = 45,
                        SecondRegIDScore = 0,
                        MatchID = 7
                    },
                    new SetResult
                    {
                        set = 1,
                        FirstRegIDScore = 45,
                        SecondRegIDScore = 0,
                        MatchID = 8
                    },
                    new SetResult
                    {
                        set = 2,
                        FirstRegIDScore = 45,
                        SecondRegIDScore = 0,
                        MatchID = 8
                    },
                    new SetResult
                    {
                        set = 3,
                        FirstRegIDScore = 45,
                        SecondRegIDScore = 0,
                        MatchID = 8
                    },
                    new SetResult
                    {
                        set = 4,
                        FirstRegIDScore = 45,
                        SecondRegIDScore = 0,
                        MatchID = 8
                    },
                    new SetResult
                    {
                        set = 1,
                        FirstRegIDScore = 45,
                        SecondRegIDScore = 0,
                        MatchID = 9
                    },
                    new SetResult
                    {
                        set = 2,
                        FirstRegIDScore = 45,
                        SecondRegIDScore = 0,
                        MatchID = 9
                    },
                    new SetResult
                    {
                        set = 3,
                        FirstRegIDScore = 45,
                        SecondRegIDScore = 0,
                        MatchID = 9
                    },
                    new SetResult
                    {
                        set = 4,
                        FirstRegIDScore = 45,
                        SecondRegIDScore = 0,
                        MatchID = 9
                    }
                    );
                context.SaveChanges();

                //Check final results if it has data
                if (context.FinaleResults.Any())
                {
                    return;// return because information exists
                }

                context.FinaleResults.AddRange(
                    new FinaleResult
                    {
                        MatchID = 1,
                        WinRegistrationID = 1,
                        WinRegistrationFinaleScore = 4,
                        SecondRegistrationID = 2,
                        SecondPlayerScore = 0,
                        SetsPlayed = 4

                    },
                    new FinaleResult
                    {
                        MatchID = 2,
                        WinRegistrationID = 3,
                        WinRegistrationFinaleScore = 4,
                        SecondRegistrationID = 4,
                        SecondPlayerScore = 0,
                        SetsPlayed = 4

                    },
                    new FinaleResult
                    {
                        MatchID = 3,
                        WinRegistrationID = 5,
                        WinRegistrationFinaleScore = 4,
                        SecondRegistrationID = 6,
                        SecondPlayerScore = 0,
                        SetsPlayed = 4

                    },
                    new FinaleResult
                    {
                        MatchID = 4,
                        WinRegistrationID = 7,
                        WinRegistrationFinaleScore = 4,
                        SecondRegistrationID = 8,
                        SecondPlayerScore = 0,
                        SetsPlayed = 4

                    },
                    new FinaleResult
                    {
                        MatchID = 5,
                        WinRegistrationID = 1,
                        WinRegistrationFinaleScore = 4,
                        SecondRegistrationID = 3,
                        SecondPlayerScore = 0,
                        SetsPlayed = 4

                    },
                    new FinaleResult
                    {
                        MatchID = 6,
                        WinRegistrationID = 5,
                        WinRegistrationFinaleScore = 4,
                        SecondRegistrationID = 7,
                        SecondPlayerScore = 0,
                        SetsPlayed = 4

                    },
                    new FinaleResult
                    {
                        MatchID = 7,
                        WinRegistrationID = 1,
                        WinRegistrationFinaleScore = 4,
                        SecondRegistrationID = 5,
                        SecondPlayerScore = 0,
                        SetsPlayed = 4

                    },
                    new FinaleResult
                    {
                        MatchID = 8,
                        WinRegistrationID = 7,
                        WinRegistrationFinaleScore = 4,
                        SecondRegistrationID = 9,
                        SecondPlayerScore = 0,
                        SetsPlayed = 4

                    },
                    new FinaleResult
                    {
                        MatchID = 9,
                        WinRegistrationID = 1,
                        WinRegistrationFinaleScore = 4,
                        SecondRegistrationID = 7,
                        SecondPlayerScore = 0,
                        SetsPlayed = 4
                    }
                    );
                context.SaveChanges(); 
            }

        }
    }
}
