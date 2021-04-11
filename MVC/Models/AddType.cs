using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NoteMarketPlace.Models
{
    public class AddType
    {
        [Key]
        public int TypeID { get; set; }

        [Required(ErrorMessage = "Please enter Type name")]
        public string TypeName { get; set; }

        [Required(ErrorMessage = "Please enter Type Description")]
        public string TypeDescription { get; set; }

    }
}