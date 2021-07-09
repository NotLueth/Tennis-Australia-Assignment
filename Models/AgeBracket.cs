using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TennisAustraliaAssignment.Models
{
    public class AgeBracket
    {
        
        //Agebracket ID is hidden and records the entries
        [Key]
        public int AgeBracketID { get; set; }

        //Name of the age bracket
        [Required(ErrorMessage ="Please Input a Name for AgeBracket")]
        [StringLength(50, ErrorMessage = "Name does not meet the appropriate length")]
        public string AgeBracketName { get; set; }

        //Description of the age bracket
        [Required(ErrorMessage = "Please Input a Description for AgeBracket")]
        [StringLength(500, ErrorMessage = "Name does not meet the appropriate length")]
        public string AgeBracketDescription { get; set; }
    }
}
