using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Employee
    {
        public virtual void PrintName(string fname, string lname)
        {
            Console.WriteLine("Full Name : {0}", fname + " " + lname);
        }
    }
    public class Child : Employee
    {
        public override void PrintName(string fname, string lname)
        {
            Console.WriteLine("Employee Full Name : {0}", fname + " " + lname);
        }
    }
    
}
