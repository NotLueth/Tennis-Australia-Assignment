using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TennisAustraliaAssignment.Models
{
    public class Tournament
    {
        //Tournament ID field used as the primary key
        [Key]
        public int TournamentID { get; set; }

        //Tournament Name field
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Must enter Tournament Name")]
        [Required(ErrorMessage ="Tournament Name required")]
        public string TournamentName { get; set; }

        //Qualifier field
        [Required(ErrorMessage ="Please enter if tournament is a qualifer or not")]
        [StringLength(3, MinimumLength = 2, ErrorMessage = "Please enter yes or no for answer")]
        public string Qualifier { get; set; }

        //Start date of Tournament field
        [Required(ErrorMessage = "Please Enter Tournament Start Date")]
        public DateTime StartDate { get; set; }

        //End date of Tournament field
        [Required(ErrorMessage = "Please Enter Tournament End Date")]
        public DateTime EndDate { get; set; }

        //Start date of Tournament signup field
        [Required(ErrorMessage = "Please Enter Tournament Signup start Date")]
        public DateTime SingupStartDate {get; set;}

        //End date of Tournament signup field
        [Required(ErrorMessage = "Please Enter Tournament Signup End Date")]
        public DateTime SingupEndDate { get; set; }

        //Prize money field
        [Required(ErrorMessage ="Must enter a value for the prize money, 0 if there is none")]
        [Range(0,9999, ErrorMessage ="Range is 0 - 9999")]
        public int PrizeMoney { get; set; }

        //Venue ID field
        [Required(ErrorMessage = "Venue ID required")]
        public int VenueID { get; set; }

        //Reference to Venue
        public Venue Venue { get; set; }

        //Tournament type ID field
        [Required(ErrorMessage = "Tournament Type required")]
        public int TournamentTypeID { get; set; }

        //Reference to Tournament type 
        public TournamentType TournamentType { get; set; }

        //Organiser ID field
        [Required(ErrorMessage = "Organiser ID required")]
        public int OrganiserPersonalID { get; set; }

        //Reference to Organiser
        public Organiser Organiser { get; set; }
    }
}
