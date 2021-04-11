using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NoteMarketPlace.Models
{
    public class AddAdmin
    {
        [Required(ErrorMessage = "Please enter First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter Email ID")]
        public string EmailID { get; set; }

        public string PhoneCountryCode { get; set; }

        public string PhoneNo { get; set; }
        
    }
}