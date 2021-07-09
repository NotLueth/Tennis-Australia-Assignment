using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TennisAustraliaAssignment.Models
{
    public class Registration
    {
        //Registration ID field
        [Key]
        public int RegistrationID { get; set; }

        //Registration signdate field
        [Required(ErrorMessage ="Please Enter a date that Registration number was made")]
        public DateTime RegistrationSignDate { get; set; }
    }
}
