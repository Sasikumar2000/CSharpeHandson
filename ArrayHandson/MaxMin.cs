using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class MaxMin
    {
        public void MinMax()
        {
            Console.Write("Enter the size of the array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] values = new int[size];
            for (int i = 0; i < values.Length; i++)
            {
                Console.Write("Enter the value of element : ");
                values[i] = Convert.ToInt32(Console.ReadLine());
            }
            int j = values[0];
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > j)
                {
                    j = values[i];
                }



            }
            Console.WriteLine("Max Value is : " + j);



            int k = values[0];
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < k)
                {
                    k = values[i];
                }

            }
            Console.WriteLine("Min Value is : " + k);
            Console.WriteLine(" ");

        }


    }
}
