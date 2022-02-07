using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class User
    {
        public virtual void UserLogin(string uname, string password, string role)
        {
            if (role == "user" && (uname == "user" && password == "user@123"))
            {
                Console.WriteLine("{0} is valid and Loged sucessfully.........", role);
            }
            else
            {
                Console.WriteLine("Invalid User Name or Password!");
            }
        }
    }

    public class Admin : User
    {
        public override void UserLogin(string uname, string password, string role)
        {
            if (role == "Admin" && (uname == "Admin" && password == "admin@123"))
            {
                Console.WriteLine("{0} is valid and Loged sucessfully.........", role);
            }
            else
            {
                Console.WriteLine("Invalid User Name or Password!");
            }
        }

    }
    public class SuperAdmin : User
    {
        public override void UserLogin(string uname, string password, string role)
        {
            if (role == "SuperAdmin" && (uname == "SuperAdmin" && password == "admin@123"))
            {
                Console.WriteLine("{0} is valid and Loged sucessfully.........", role);
            }
            else
            {
                Console.WriteLine("Invalid User Name or Password!");
            }
        }
    }
}
