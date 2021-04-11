using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NoteMarketPlace.Models
{
    public class UserProfileModel
    {

        [Key]
        public int ProfileID { get; set; }

        [Required(ErrorMessage = "Please enter first name")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Numeric entry not allowed")]
        public string FirstName { get; set; }


        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Numeric entry not allowed")]
        [Required(ErrorMessage = "Please enter last name")]
        public string LastName { get; set; }

        public string EmailId { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MMM-yyyy}")]
    
        public DateTime? DOB { get; set; }

        [Required(ErrorMessage = "Please select Gender")]
        public int Gender { get; set; }


        [Required(ErrorMessage = "Please enter country code")]
        public string CountryCode { get; set; }

        [Required(ErrorMessage = "Please enter phone number")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        public string PhoneNo { get; set; }
        public HttpPostedFileBase ProfilePic { get; set; }

        public string SecondaryEmailAddress { get; set; }

        [Required(ErrorMessage = "Please enter address")]
        public string Address1 { get; set; }

        [Required(ErrorMessage = "Please enter address")]
        public string Address2 { get; set; }

        [Required(ErrorMessage = "Please enter city")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter state")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter zipcode")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Please enter country")]
        public int Country { get; set; }
        public string University { get; set; }
        public string College { get; set; }

        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public bool IsActive { get; set; }


    }
}