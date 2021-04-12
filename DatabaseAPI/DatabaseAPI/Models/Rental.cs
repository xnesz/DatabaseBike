using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseAPI.Models
{
    public class Rental
    {

            public int RentalId { get; set; }
            public Customer customer { get; set; }
            [Required]
            [ForeignKey("Customer")]
            public int CustomerFK { get; set; }
            [Required]
            public decimal Price { get; set; }
            [Required]
            public string Rental_Date { get; set; }
            [Required]
            public string Rental_Expiry { get; set; }
         

    }
}
