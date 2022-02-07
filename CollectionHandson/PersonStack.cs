using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection
{
    class PersonStack
    {
        public void StackList()
        {
            Stack name = new Stack();
            Stack age = new Stack();

            Console.Write("Enter a Number of Details : ");
            int size = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < size; i++)
            {
                Console.Write("Enter a Name : ");
                name.Push(Console.ReadLine());

                Console.Write("Enter a age : ");
                age.Push(Console.ReadLine());
            }

            int j = 0;
            while ( j < name.Count)
            {
                Console.WriteLine(name.Pop().ToString() + " - " + age.Pop().ToString());
            }
        }
    }
}
