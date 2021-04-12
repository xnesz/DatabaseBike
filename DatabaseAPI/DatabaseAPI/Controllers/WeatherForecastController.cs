using DatabaseAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly RentDBContext _context;
        public  WeatherForecastController(RentDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            /*_context.Database.EnsureCreated();
            Customer customer = new Customer();
             customer.First_Name = "Anna";
             customer.Last_Name = "Johnson";
             customer.Email = "adsdsa@asds.se";
             customer.Card_Number = "123456783456";
             customer.Card_Name = "Anna Johnson";
             customer.Card_Date = "04/43";
             customer.Card_CVC = "3";
             customer.Address = "djfds23";




             _context.Customers.Add(customer);


               _context.SaveChanges();*/

             return _context.Customers.ToList();



           // return new List<Customer>();
        }
    }
}
