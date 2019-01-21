using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyExample
{
    class ProxyCustomerDataAccessObject : ICustomerDataAccessObject
    {
        CustomerDataAccessObject _customDataAccessObject = null;
        bool _authenticated = false;

        public ProxyCustomerDataAccessObject(int userId)
        {
            var authenticator = new Authenticator();

            if (authenticator.AuthenticateUser(userId))
                _customDataAccessObject = new CustomerDataAccessObject();

        }

        public List<Customer> GetActiveCustomer()
        {
            if (_authenticated)
                return _customDataAccessObject.GetActiveCustomer();
            else
                return new List<Customer>(); 

        }
    }
}
