using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                There's a couple use cases for the proxy.
                Here I'm going to use the proxy pattern 
                to defer a mock DB call only after the
                user is verified to be part of the system.

                in the logic here, if you're not authenticated
                an empty list is sent.
                             
             */


            int userId = 3;
            var cusDao = new ProxyCustomerDataAccessObject(userId);
            var customers = cusDao.GetActiveCustomer();

            foreach (var cus in customers)
            {
                Console.WriteLine(cus.CustomerName); 
            }

        }
    }
}
