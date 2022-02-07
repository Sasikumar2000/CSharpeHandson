using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum s = new Sum();
            CountDuplicate d = new CountDuplicate();
            CountUnique u = new CountUnique();
            PrintUnique p = new PrintUnique();
            MaxMin m = new MaxMin();
            int i;
            do
            {
                Console.WriteLine("1.To Sum of Array elements");
                Console.WriteLine("2.To  Count  Duplicate elements in Array ");
                Console.WriteLine("3.To  Count  Unique elements in Array");
                Console.WriteLine("4.To find the Unique element of Array");
                Console.WriteLine("5.To find Max and Min of Array elements");
                Console.WriteLine("6.Exit");
                Console.Write("Enter Your Choice : ");
                i = Convert.ToInt32(Console.ReadLine());

                switch (i)
                {
                    case 1: s.SumArray(); break;
                    case 2: d.DuplicateCount(); break;
                    case 3: u.UniqueCount(); break;
                    case 4: p.UniquePrint(); break;
                    case 5: m.MinMax(); break;
                    case 6: Console.WriteLine("Exiting..."); break;
                }

            } while (i != 6);
           
            
            Console.ReadKey();
        }
    }
}
