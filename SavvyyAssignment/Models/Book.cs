using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace SavvyyAssignment.Models
{
    public class Book
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string title { get; set; }
        public string description { get; set; }
        [Required]
        public string author { get; set; }
        public string coverImage { get; set; }
        public double price { get; set; }
    }
}
