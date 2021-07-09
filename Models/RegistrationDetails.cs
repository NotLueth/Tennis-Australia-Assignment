using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TennisAustraliaAssignment.Models
{
    public class RegistrationDetails
    {
        //Registration details ID, this is hidden to the user
        [Key]
        public int RegistrationDetailsID { get; set; }

        //Registraion ID field
        [Required(ErrorMessage = "Enter a Registration ID")]
        public int RegistrationID { get; set; }

        //Reference to registration
        public Registration Registration { get; set; }

        //Player ID field
        [Required(ErrorMessage = "Enter a Player ID")]
        [Display(Name = "Full Name")]
        public int PlayerPersonalID { get; set; }

        //Reference to Player
        public Player Player { get; set; }
    }
}
