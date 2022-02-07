using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListHandon
{
    class ListRemove
    {
        static string Sremove(string str)
        {
            if (str.Contains('a'))
            {
                str = string.Join("",str.Split('a'));
                return str;
            }
            else
            {
                return str;
            }
        }

        public void Remove()
        {
            List<string> strBefore = new List<string>();
            List<string> strAfter = new List<string>();

            Console.Write("Enter no of input : ");
            int size = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter a String {i+1} : ");
                strBefore.Add(Console.ReadLine());
            }

            foreach (var item in strBefore)
            {
                strAfter.Add(Sremove(item));
            }

            Console.WriteLine("Output");
            foreach (var item in strAfter)
            {
                Console.WriteLine(item);
            }
        }
    }
}
