using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPITest.Models;

namespace WebAPITest.Controllers
{
    public class CustomerController : ApiController
    {
        public static List<Customer> allCustomers = new List<Customer>();
        
        public List<Customer> Get()
        {
            if(allCustomers.Count == 0)
            {
                allCustomers.Add(new Customer
                {
                    CustomerID = 1000,
                    CustomerName = "Customer100"
                });
                
            }

            return allCustomers.ToList();
        }

        public bool Post(Customer customer)
        {
            allCustomers.Add(customer);
            return true;
        }
    }
}
