using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TennisAustraliaAssignment.Models
{
    public class SetResult
    {
        //Set result ID, this is hidden to the user
        [Key]
        public int SetResultID { get; set; }

        //the set field
        [Required(ErrorMessage = "Must enter the set number")]
        [Range(1,100, ErrorMessage = "Range is 1 - 100")]
        public int set { get; set; }

        //the first registration score of the sets field
        [Required(ErrorMessage = "Must enter the first registration Score")]
        public int FirstRegIDScore { get; set; }

        //the second registration score of the sets field
        [Required(ErrorMessage = "Must enter the second registration Score")]
        public int SecondRegIDScore { get; set; }

        //the match ID field
        [Required(ErrorMessage = "Must Enter the Match ID that relates to the set")]
        public int MatchID { get; set; }

        //Reference to the Match
        public Match Match { get; set; }
    }
}
