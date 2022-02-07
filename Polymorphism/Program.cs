using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MethodOverloading
            //MethodOverloading

            /*MethodOverloading user = new MethodOverloading();
            user.UserLogin("user", "user@123");
            user.UserLogin("admin", "admin@123", "Admin");*/
            #endregion

            #region MethodOverriding
            //MethodOverriding

            Employee emp;
            /*emp = new Child();
            emp.PrintName("Sasi", "Kumar");*/

            emp = new Employee();
            emp.PrintName("Gokul", "Kumar");
            #endregion


            Console.ReadKey();
        }
    }
}
