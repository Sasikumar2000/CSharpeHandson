using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssemblyHandson
{
    static class SuccessRate
    {
        public static double Successrate(int x)
        {
            if(x == 0)
            {
                return 0;
            }
            else if ( x <= 4 && x >= 1)
            {
                return 1;

            }
            else if ( x <= 8 && x >= 5)
            {
                return 0.9;

            }
            else if ( x == 9)
            {
                return 0.8;

            }
            else if ( x == 10)
            {
                return 0.77;

            }
            else
            {
                Console.WriteLine("Rate Correctly");
                return 0;

            }
        }

        public static double ProductionRatePerHour(int x)
        {
            double sum = Successrate(x) * 221 * x;
            return sum;
        }
        public static void WorkingItemsPerMinute(int x)
        {
            int sum = Convert.ToInt32(ProductionRatePerHour(x)) / 60;
            Console.WriteLine(sum);
        }
    }
}
