using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace DatabaseAPI.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required]
        public string First_Name { get; set; }
        [Required]
        public string Last_Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Card_Number { get; set; }
        [Required]
        public string Card_Name { get; set; }
        [Required]
        public string Card_Date { get; set; }
        [Required]
        public string Card_CVC { get; set; }
        
    }
}
