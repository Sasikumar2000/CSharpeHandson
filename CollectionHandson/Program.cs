using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personObj = new Person();
            PersonQueue personQueueObj = new PersonQueue();
            PersonStack personStackObj = new PersonStack();
            Console.WriteLine(" ");
            int i;
            do
            {
                Console.WriteLine(" ");

                Console.WriteLine("1.ArrayList \n2.Stack \n3.Queue \n4.Exit");

                Console.WriteLine(" ");

                Console.Write("Enter your option : ");
                i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                switch (i)
                {
                    case 1: personObj.PersonData(); break;
                    case 2: personStackObj.StackList(); break;
                    case 3: personQueueObj.QueueList(); break;
                    case 4: Console.WriteLine("Exiting...."); break;
                    default: Console.WriteLine(" Enter Vaild option ");break;
                }
            } while (i != 4);

            Console.ReadKey();
        }
    }
}
