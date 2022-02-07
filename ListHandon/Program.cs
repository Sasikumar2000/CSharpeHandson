using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListHandon
{
    class Program
    {
        static void Main(string[] args)
        {
            ListAdd listAddObj = new ListAdd();
            ListCon conObj = new ListCon();
            ListRemove removeObj = new ListRemove();
            
            int i;
            do
            {
                Console.WriteLine("\n1.Add and Multiply \n2.Concate \n3.Remove \n4.Exit \n");

                Console.Write("Enter your Option : ");
                i = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");

                switch (i)
                {
                    case 1: listAddObj.Add(); break;
                    case 2: conObj.Concat(); break;
                    case 3: removeObj.Remove(); break;
                    case 4: Console.WriteLine("Exiting..."); break;
                    default:Console.WriteLine("Invaild Option"); break;
                }
            } while (i != 4);

            Console.ReadKey();
        }
    }
}
