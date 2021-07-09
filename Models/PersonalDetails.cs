using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TennisAustraliaAssignment.Models
{
    public abstract class PersonalDetails
    {
        //Hidden value of the table that tracks entries
        [Key]
        public int PersonalID { get; set; }

        //this is used so that when a player or organiser is being selected the user can see who they are with this field
        //its made up of the first and last name and is not apart of the database
        [NotMapped]
        public string FullName { get { return FirstName + " " + LastName; } }

        //First name field
        [RegularExpression(@"^[a-zA-Z]+[a-zA-Z\s]*$", ErrorMessage = "Not a valid Name")]
        [Required(ErrorMessage = "Please Input a First Name")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Name does not meet the appropriate length")]
        public string FirstName { get; set; }

        //Last name field
        [RegularExpression(@"^[a-zA-Z]+[a-zA-Z\s]*$", ErrorMessage = "Not a valid Last Name")]
        [Required(ErrorMessage = "Please Input a Last Name")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Name does not meet the appropriate length")]
        public string LastName { get; set; }

        //Age field
        [Required(ErrorMessage = "Please Input a Age")]
        [Range(10,99, ErrorMessage ="Range is 10 - 99")]
        public int Age { get; set; }

        //Street field
        [RegularExpression(@"^[a-zA-Z0-9""'\s-]*$", ErrorMessage = "Not a valid Street")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Street does not meet the appropriate length")]
        [Required(ErrorMessage ="Please Enter a Street and Number")]
        public string Street { get; set; }


        //city field
        [RegularExpression(@"^[a-zA-Z]+[a-zA-Z\s]*$", ErrorMessage = "Not a valid City")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "City does not meet the appropriate length")]
        [Required(ErrorMessage = "Please Enter a City")]
        public string City { get; set; }


        //Postcode field
        [Range(0, 9999)]
        [Required(ErrorMessage = "Please Enter a Postcode")]
        public int Postcode { get; set; }

        //Email field
        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        //Phone field
        [Required(ErrorMessage = "You must provide a phone number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string Phone { get; set; }
    }
}
