using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NoteMarketPlace.Models
{
    public class AdminProfile
    {
        [Key]
        public int ProfileID { get; set; }

        [Required(ErrorMessage = "Please enter first name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter last name")]
        public string LastName { get; set; }

        public string EmailId { get; set; }

        [Required(ErrorMessage = "Please enter country code")]
        public string CountryCode { get; set; }

        [Required(ErrorMessage = "Please enter phone number")]
        public string PhoneNo { get; set; }

        public string SecondaryEmailAddress { get; set; }

        public HttpPostedFileBase ProfilePic { get; set; }
       
        public int Gender { get; set; }

        public int Country { get; set; }
       public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public bool IsActive { get; set; }
    }
}