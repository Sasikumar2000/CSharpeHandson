using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn2
{
    class Candy
    {
        List<int> candy = new List<int>();
        List<int> candy1 = new List<int>();
        public void Diff()
        {
            Console.Write("Enter a number of candies : ");
            int size = int.Parse(Console.ReadLine());
            
            Console.Write("Enter candies : ");
            string s1 = Console.ReadLine();
            string[] s2 = s1.Split(' ');
            int[] arr = new int[size]; // 1 2 2 2 1 1
            
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(s2[i]);
            }

            for (int i = 0; i < size; i++)
            {
                bool IsDup = false;
                for (int j = i+1; j < size; j++)
                {
                    if ( arr[i] == arr[j])  
                    {
                        IsDup = true;
                        break;
                    }
                }

                if (!IsDup)
                {
                    candy.Add(arr[i]);
                }
            }

            for (int i = 0; i < candy.Count; i++)
            {
                candy1.Add(0);
                for (int j = 0; j < arr.Length; j++)
                {
                    if( candy[i] == arr[j])
                    {
                        candy1[i]++;
                    }
                }
            }
            
            for (int i = 0; i < candy1.Count; i++)
            {
                if( candy1[i] == candy1[i + 1] && (candy1[1]*candy1.Count) == arr.Length )
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine(candy1[i]);
                    break;
                }
                else
                {
                    Console.WriteLine("No");
                    Console.WriteLine(arr.Distinct().Count());
                    break;
                }
            }

           /* Array.Sort(arr);
            int n = 0;
            int x = 0;
            for (int i = 0; i < size; i++)  
            {
                
                for (int j = i; j < size; j++)    
                {
                    if (arr[i] == arr[j])   
                    {
                        n = n + 1;
                    }
                    else
                    {
                        x = n;
                        n = 0;
                        i = j;
                        break;
                    }
                    Console.WriteLine(x);
                }
                
            }*/
            //Console.WriteLine(x);
            
            

        }
    }
}
