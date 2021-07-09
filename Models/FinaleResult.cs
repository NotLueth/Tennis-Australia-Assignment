using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TennisAustraliaAssignment.Models
{
    public class FinaleResult
    {
        [Key]
        //Hidden ID field to kep track of final results
        public int FinaleResultID { get; set; }

        //The match ID of the match that the results are for
        [Required (ErrorMessage ="Must Provide a Match ID")]
        public int MatchID { get; set; }
        //reference to Match
        public Match Match { get; set; }

        //The winning registration ID for those who won the match
        [Required(ErrorMessage = "Must Provide the registration ID of the Winner")]
        public int WinRegistrationID { get; set; }

        //The overall winning score not the individual scores of the sets thats for set results
        [Required(ErrorMessage = "Must Enter a Score for the Winner Registration ID")]
        [Range(1, 50, ErrorMessage = "Range can only be from 1 - 50")]
        public int WinRegistrationFinaleScore { get; set; }


        //the second registration of the game and is the loser
        public int SecondRegistrationID { get; set; }

        //The overall loser score not the individual scores of the sets thats for set results
        [Required (ErrorMessage ="Must Enter a Score for the second Registration ID")]
        [Range(1,50, ErrorMessage ="Range can only be from 1 - 50")]
        public int SecondPlayerScore { get; set; }

        //Reference to registrations
        public Registration Registration { get; set; }

        //Total sets played for the whole match
        [Required (ErrorMessage = "Must Provide total sets played during Match")]
        [Range(1,100, ErrorMessage ="Range can only be from 1 - 100")]
        public int SetsPlayed { get; set; }
    }
}
