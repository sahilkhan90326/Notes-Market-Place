using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NoteMarketPlace.Models
{
    public class AddCategory
    {
        [Key]
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "Please enter category name")]
        public string CategoryName { get; set; }

        [Required(ErrorMessage = "Please enter category description")]
        public string CategoryDescription { get; set; }

    }
}