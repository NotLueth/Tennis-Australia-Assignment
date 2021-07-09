using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TennisAustraliaAssignment.Models
{
    //inherits personal details
    public class Organiser : PersonalDetails
    {   
        //organiser start date of employment
        [Required(ErrorMessage = "Please Input a Start Date for the Organiser")]
        public DateTime StartDate { get; set; }
    }
}
