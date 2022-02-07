using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Sum
    {
        
        public void SumArray()
        {
            Console.Write("Enter a Size of Array : ");
            int n =Convert.ToInt32(Console.ReadLine());
            int[] num = new int[n];
            int sum = 0;

            for( int i = 0; i < n; i++ )
            {
                Console.Write("Enter a element " + (i+1) + ": ");
                num[i] =Convert.ToInt32(Console.ReadLine());
                sum += num[i];
            }

            Console.WriteLine("The Sum of the array is " + sum);

            Console.WriteLine(" ");
        }
    }
}
