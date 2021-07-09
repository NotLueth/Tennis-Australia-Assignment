using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TennisAustraliaAssignment.Models
{
    public class TournamentType
    {
        //Tournament type ID
        public int TournamentTypeID { get; set; }

        //Tournament type Name field
        [Required(ErrorMessage ="Must enter Tournament type name")]
        [StringLength(100, MinimumLength = 2, ErrorMessage ="Tournament type name does not meet the appropriate length")]
        public string TournamentTypeName { get; set; }

        //Tournament type description field
        [Required(ErrorMessage = "Must enter Tournament type description")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Tournament type description does not meet the appropriate length")]
        public string TournamentTypeDescription { get; set; }
    }
}
