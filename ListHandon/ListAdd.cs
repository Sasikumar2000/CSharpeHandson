using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListHandon
{
    class ListAdd
    {
        public int AddMult(int x)
        {
            return (x + 2) * 5;
        }
        public void Add()
        {
            List<int> num = new List<int>();
            List<int> result = new List<int>();


            Console.Write("Enter no of input : ");
            int size = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter a Input : ");
                num.Add(Convert.ToInt32(Console.ReadLine()));
            }

            foreach (var item in num)
            {
                result.Add(AddMult(item));
            }

            Console.WriteLine("Output");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
