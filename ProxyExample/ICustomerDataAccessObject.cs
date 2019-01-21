using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyExample
{
    interface ICustomerDataAccessObject
    {
        List<Customer> GetActiveCustomer();
    }
}
