using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TennisAustraliaAssignment.Models;

namespace TennisAustraliaAssignment.Data
{
    public class TennisContext : DbContext
    {
        //set the options for the database
        public TennisContext(DbContextOptions<TennisContext> options) : base(options)
        { }
        //set the database for the following with the get and set needed to retrieve the data
        public DbSet<PersonalDetails> PersonalDetails { get; set; }
        //set the database for the following with the get and set needed to retrieve the data
        public DbSet<AgeBracket> AgeBracket { get; set; }
        //set the database for the following with the get and set needed to retrieve the data
        public DbSet<FinaleResult> FinaleResults { get; set; }
        //set the database for the following with the get and set needed to retrieve the data
        public DbSet<LeagueRating> LeagueRatings { get; set; }
        //set the database for the following with the get and set needed to retrieve the data
        public DbSet<Match> Matches { get; set; }
        //set the database for the following with the get and set needed to retrieve the data
        public DbSet<Organiser> Organisers { get; set; }
        //set the database for the following with the get and set needed to retrieve the data
        public DbSet<Player> Players { get; set; }
        //set the database for the following with the get and set needed to retrieve the data
        public DbSet<Registration> registrations { get; set; }
        //set the database for the following with the get and set needed to retrieve the data
        public DbSet<RegistrationDetails> RegistrationDetails { get; set; }
        //set the database for the following with the get and set needed to retrieve the data
        public DbSet<SetResult> setResults { get; set; }
        //currently left out but was orignally used for composite keys
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            // modelBuilder.Entity<SetResult>().HasKey(setresult => new { setresult.set, setresult.MatchID });
            //  modelBuilder.Entity<RegistrationDetails>().HasKey(RegistrationDetails => new { RegistrationDetails.PlayerID, RegistrationDetails.RegistrationID });
        }
        //set the database for the following with the get and set needed to retrieve the data
        public DbSet<Surface> Surface { get; set; }
        //set the database for the following with the get and set needed to retrieve the data
        public DbSet<Tournament> Tournaments { get; set; }
        //set the database for the following with the get and set needed to retrieve the data
        public DbSet<TournamentBracket> TournamentBrackets { get; set; }
        //set the database for the following with the get and set needed to retrieve the data
        public DbSet<TournamentType> TournamentTypes { get; set; }
        //set the database for the following with the get and set needed to retrieve the data
        public DbSet<Venue> Venue { get; set; }
    }
}
