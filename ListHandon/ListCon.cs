using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListHandon
{
    class ListCon
    {
        static string Con(string x)
        {
            return x + x + x + x;
        }
        public void Concat()
        {
            List<string> tocon = new List<string>();
            List<string> con = new List<string>();

            Console.Write("Enter no of input : ");
            int size = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter a Input : ");
                tocon.Add(Console.ReadLine());
            }

            foreach (var item in tocon)
            {
                con.Add(Con(item));
            }

            Console.WriteLine("Output");
            foreach (var item in con)
            {
                Console.WriteLine(item);
            }
        }

    }
}
