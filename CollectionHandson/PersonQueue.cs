using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection
{
    class PersonQueue
    {
        public void QueueList()
        {
            Queue list = new Queue();

            Console.Write("Enter a Number of Details : ");
            int size = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter a Name : ");
                string name = Console.ReadLine();
                Console.Write("Enter a age : ");
                string age = Console.ReadLine().ToString();

                list.Enqueue(name + " - " + age);
            }
            foreach( var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
