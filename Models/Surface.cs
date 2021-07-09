using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TennisAustraliaAssignment.Models
{
    public class Surface
    {
        //Surface ID and is hidden to the user
        public int SurfaceID { get; set; }

        //SUrface name field
        [Required(ErrorMessage ="Must Enter Surface Name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$", ErrorMessage = "Not a valid Surface Name")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Surface name Does not meet the appropriate length")]
        public string SurfaceName { get; set; }

        //Surface Description field
        [StringLength(100, MinimumLength = 20, ErrorMessage = "Surface Description Does not meet the appropriate length")]
        [Required(ErrorMessage = "Must Enter Surface Description")]
        public string SurfaceDescription { get; set; }
    }
}
