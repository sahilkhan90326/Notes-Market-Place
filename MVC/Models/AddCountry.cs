using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace NoteMarketPlace.Models
{
    public class AddCountry
    {
        [Key]
        public int CountryID { get; set; }

        [Required(ErrorMessage = "Please enter Country name")]
        public string CountryName { get; set; }

        [Required(ErrorMessage = "Please enter Country Description")]
        public string CountryCode { get; set; }

    }
}