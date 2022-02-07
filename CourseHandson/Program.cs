using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 conObj = new Class1();
            int i = 0;
            do
            {
                Console.WriteLine("Select Your Course \n 1.Onsite \n 2.Part-Time\n 3.Exit\n");

                Console.Write("Enter your Option : ");
                i = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (i)
                {
                    case 1: conObj.Onsite(); break;
                    case 2: conObj.PartTime(); break;
                    case 3: Console.WriteLine("Exiting...."); break;
                    default: Console.WriteLine("Enter Correct option : "); break;
                }

            } while (i != 3);

            Console.ReadKey();
        }
    }
}
