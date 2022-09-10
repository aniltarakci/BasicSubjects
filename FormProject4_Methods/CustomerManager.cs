using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormProject4_Methods
{
    class CustomerManager
    {
        List<Customer> customers;
        public CustomerManager()
        {
            customers = new List<Customer>()
            {
                new Customer {Id = 1, FirstName = "Anıl", LastName = "Tarakcı", Age = 23, Mail = "anil@.com" },
                new Customer {Id = 2, FirstName = "Mehmet", LastName = "Ağaç", Age = 22, Mail = "mehmet@.com" },
                new Customer {Id = 3, FirstName = "Akif", LastName = "Aksoy", Age = 22, Mail = "akif@.com" }
            };
        }
        
        public List<Customer> GetAll()
        {
            return customers;
        }

        public void Add(Customer customer)
        {
            customers.Add(customer);
        }
    }
}
