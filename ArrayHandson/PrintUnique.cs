using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class PrintUnique
    {
        public void UniquePrint()
        {

            Console.Write("Enter the size of an array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] print = new int[size];
            
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter the Array element" + (i + 1) + " : ");
                print[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < size; i++)
            {
                bool isDuplicate = false;
                for (int j = i + 1; j < size; j++)
                {
                    if (print[i] == print[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                    
                }
                if (!isDuplicate)
                {
                    Console.WriteLine("The Dublicate vaule is " + print[i]);
                    Console.WriteLine(" ");

                }
            }
        }
    }
}


