using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyExample
{
    class CustomerDataAccessObject : ICustomerDataAccessObject
    {

        public CustomerDataAccessObject()
        {
            Console.WriteLine("DB Conntect");
        }

        public List<Customer> GetActiveCustomer()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer("Billy"));
            customers.Add(new Customer("Bob"));
            customers.Add(new Customer("Allen"));
            customers.Add(new Customer("Jared"));
            customers.Add(new Customer("Frank"));
            customers.Add(new Customer("Lillian"));
            //Customer list from the DB

            return customers;
        }
    }
}
