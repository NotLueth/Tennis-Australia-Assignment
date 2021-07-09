using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TennisAustraliaAssignment.Models
{
    public class TournamentBracket
    {
        //Tournament Bracket ID field
        public int TournamentBracketID { get; set; }

        //The tournament ID field
        [Required(ErrorMessage ="Must enter Tournament ID")]
        public int TournamentID { get; set; }

        //Reference to Torunament
        public Tournament Tournament { get; set; }

        //Age bracket ID field
        [Required(ErrorMessage = "Must enter Age Bracket")]
        public int AgeBracketID { get; set; }

        //Reference to Agebracket
        public AgeBracket AgeBracket { get; set; }

        //League ID field
        [Required(ErrorMessage = "Must enter League rating")]
        public int LeagueRatingLeagueID { get; set; }

        //Reference to League rating
        public LeagueRating LeagueRating { get; set; }
    }
}
