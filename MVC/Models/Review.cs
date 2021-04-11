using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NoteMarketPlace.Models
{
    public class Review
    {
   
        public decimal Ratings { get; set; }

       
        public string Comments { get; set; }
    }
}
