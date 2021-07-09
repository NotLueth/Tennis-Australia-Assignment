using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TennisAustraliaAssignment.Models
{
    //Inherits the personal details model
    public class Player : PersonalDetails
    {
        //tennis membership number field
        [Required(ErrorMessage ="Please enter a Membership Number")]
        [Range(0, 99999)]
        public int TennisMembershipNumber { get; set; }

        //Australia ranking field
        [Range(0, 99999)]
        [Required(ErrorMessage = "Please enter a Ranking")]
        public int AustralianRanking { get; set; }

        //Universal rating field
        [Required(ErrorMessage = "Please enter a rating")]
        [Range(0, 99999)]
        public int UniversalTennisRating { get; set; }
    }
}
