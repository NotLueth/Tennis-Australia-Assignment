using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TennisAustraliaAssignment.Models
{
    public class LeagueRating
    {
        [Key]
        //The Hidden league ID to track entries
        public int LeagueID { get; set; }
        
        //Name of the league
        [Required(ErrorMessage ="Must Provide a League Rating Name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage ="Name does not meet the appropriate length")]
        public string LeagueName { get; set; }
    }
}
