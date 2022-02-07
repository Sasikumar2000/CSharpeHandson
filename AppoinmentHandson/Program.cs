using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppoinmentHandson
{
    class Program
    {
        static void Main(string[] args)
        {
            void ForCase1()
            {
                DateTime date = Appoinment.Schedule();
                if (Appoinment.HasPassed(date) && Appoinment.IsAfternoonAppointment(date))
                {
                    Appoinment.Description(date);
                }
                
                Appoinment.AnniversaryDate(date);
            }
            int i;
            do
            {
                Console.WriteLine("\n1.Book an Appoinment \n2.Exit. \n");
                Console.Write("Enter your option : ");
                i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                switch (i)
                {
                    case 1: ForCase1();break;
                    case 2: Console.WriteLine("Thank for using our Service..");break;
                    default: Console.WriteLine("Invalid option");break;
                }

                
            } while (i != 2);
            Console.ReadKey();
        }
    }
}
