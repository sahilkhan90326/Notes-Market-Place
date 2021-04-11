using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace NoteMarketPlace.Models
{
    public class RejectModel
    {
        public int? sellerid { get; set; }

        [Required(ErrorMessage = "Please enter remarks to enter")]
        public string Remarks { get; set; }
    }
}