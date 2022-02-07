using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HandsOn2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Candy candyObj = new Candy();
            candyObj.Diff();*/
            /*int[] vs = { 1, 2, 3, 4, 4, 4, 5, 1, 2, 3, 5 };
            var a = vs.Distinct();

            Console.WriteLine(a);*/

            /*Console.Write("Enter Product Details as comma seperated values");
            string input = Console.ReadLine();
            string[] arr = input.Split(',');
            string a = arr[0];
            string b = arr[1];
            string c = arr[2];
            int d = Convert.ToInt32(arr[3]);
            double e = Convert.ToDouble(arr[4]);
            string[] temp = arr[5].Split('-');//05 - 29 - 2020
            string temp1 = temp[1] + "-" + temp[0] + "-" + temp[2];
            DateTime f = Convert.ToDateTime(temp1);
           
            HandsOn3 handsObj = new HandsOn3(a,b,c,d,e,f);

            if (handsObj.CheckStock()  )
            {
                
                    Console.WriteLine("The Stock Is 0. Can't order the product");

                
             }
            else
            {
                if (handsObj.CheckExpiryDate())
                {
                    Console.WriteLine("Can order the product");
                }
                else
                {
                    Console.WriteLine("Can't order the product because product expiry");

                }
            }*/

            HandsOn4 handsOn4 = new HandsOn4();
            /*Console.Write("Enter a number of movies : ");
            int size = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < size; i++)
            {
                handsOn4.GetCategory();

            }*/
            handsOn4.GetCategory();
            handsOn4.MM();
            /*var numList = new List<int>() { 1, 2, 3, 2, 3, 4, 5 };
            var strList = new List<string>() { "a", "b", "c", "d", "c", "d", "e" };

            // remove duplicates from a list of integers
            var uniqueNums = numList.Distinct();
            foreach (var item in uniqueNums)
            {
                Console.WriteLine(item);

            }

            // remove duplicates from a list of strings
            var uniqueStrs = strList.Distinct().ToList();
            Console.WriteLine(string.Join(", ", uniqueStrs));*/

            Console.ReadKey();
        }
    }
}
