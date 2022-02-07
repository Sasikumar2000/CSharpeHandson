using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonHouse
{
    class Person : Apart
    {
        public string name;

        public void Pname()
        {
            Console.WriteLine("Enter your Name : ");
            name = Console.ReadLine();
            Console.WriteLine("My name is : " + name);
           
        }
    }
}
