using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TennisAustraliaAssignment.Models
{
    public class Match
    {
        //This value is hidden at the current timeto the user in this table cause its just tracking the entries but is relavent to other areas
        public int MatchID { get; set; }
        
        //round that this match is occuring in
        [Required(ErrorMessage ="Must enter a Round number for the Match")]
        [Range(1,30, ErrorMessage ="Range is 1 - 30")]
        public int Round { get; set; }

        //the bracket of the tournament this match is happening in
        [Required(ErrorMessage ="Must enter a Tournament bracket ID")]
        public int TournamentBracketID { get; set; }

        //reference to the tournamenet bracket
        public virtual TournamentBracket TournamentBracket { get; set; }
        
        //first registration of the match
        [Required(ErrorMessage = "Must input the first registration ID")]
        public int FirstRegistrationID { get; set; }
        
        //second registration of the match
        [Required(ErrorMessage = "Must input the Second registration ID")]

        public int SecondRegistrationID { get; set; }

        //reference to the registrations
        public virtual RegistrationDetails Registration { get; set; }
    }
}
