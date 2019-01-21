using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyExample
{
    class Authenticator : IAuthenticator
    {
        public bool AuthenticateUser(int userId)
        {
            Console.WriteLine("Authenticate User");
            //Assume complex authentication code
            if (userId == 1)
                return true;

            return false;
        }
    }
}
