using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class MethodOverloading
    {
        public void UserLogin(string uname, string password)
        {
            if (uname == "user" && password == "user@123")
            {
              
                Console.WriteLine("user is valid and Loged sucessfully.........");
            }
            else
            {
                Console.WriteLine("Invalid Data");
            }
        }

        public void UserLogin(string uname, string password, string role)
        {
            if (role == "Admin" && (uname == "admin" && password == "admin@123"))
            {
               
                Console.WriteLine("Admin is valid and Loged sucessfully.........");
            }
            else
            {
                Console.WriteLine("Invalid Data!");
            }
        }
    }
}
