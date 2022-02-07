using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class CountUnique
    {
            public void UniqueCount()
        {

            Console.Write("Enter the size of an array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] count = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("enter the Array element" + (i + 1) + " : ");
                count[i] = Convert.ToInt32(Console.ReadLine());



            }
            int ArrayCount = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (count[i] == count[j])
                    {
                        ArrayCount++;
                        break;
                    }
                }
            }

            Console.WriteLine("The number of Unique elements in an array is : " + (size - ArrayCount));
            Console.WriteLine(" ");

        }
    }
}
