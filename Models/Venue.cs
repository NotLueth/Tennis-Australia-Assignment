using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TennisAustraliaAssignment.Models
{
    public class Venue
    {
        //Venue ID and is hidden to the user in this table
        public int VenueID { get; set; }

        //Venue Name Field
        [Required(ErrorMessage ="Must enter a Venue name")]
        [RegularExpression(@"^[a-zA-Z0-9""'\s-]*$", ErrorMessage = "Not a valid Name")]
        [StringLength(100, MinimumLength = 5, ErrorMessage ="Venue Name does not meet the appropriate length")]
        public string VenueName { get; set; }

        //Street Field
        [Required(ErrorMessage = "Must enter a Street name and number")]
        [RegularExpression(@"^[a-zA-Z0-9""'\s-]*$", ErrorMessage = "Not a valid Street")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Street does not meet the appropriate length")]
        public string Street { get; set; }

        //City Field
        [Required(ErrorMessage = "Must enter a city name")]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Not a valid City")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "city does not meet the appropriate length")]
        public string City { get; set; }

        //State Field
        [Required(ErrorMessage = "Must enter a State acronyme name")]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Not a valid State acronyme")]
        [StringLength(4, MinimumLength = 0, ErrorMessage = "Must enter State acronyme")]
        public string State { get; set; }

        //Surface ID Field
        [Required(ErrorMessage = "Must enter a Surface ID")]
        public int SurfaceID { get; set; }

        //Reference to Surface
        public Surface Surface { get; set; }
    }
}
