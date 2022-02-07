using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Class1
    {
        public string CourseName { get; set; }
        public string CourseDuration { get; set; }
        public int Fee { get; set; }

        public void Onsite()
        {
            CourseName = "ASP.Net";
            CourseDuration = "140 hrs";
            Fee = 5500;

            Console.Write("Enter your Name  : ");
            string Name = Console.ReadLine();
            Console.Write("Enter your CompanyName  : ");
            string Company = Console.ReadLine();
            Print(Name, Company);

        }

        public void Print(string Name, string Company)
        {
            Console.WriteLine();

            Console.WriteLine("Canditate Name : " + Name);
            Console.WriteLine("Canditate Company Name : " + Company);

            Console.WriteLine("Course : " + CourseName);
            Console.WriteLine("Duration : " + CourseDuration);
            Console.WriteLine("Fee : " + Fee);
            Console.WriteLine();

        }

        public void PartTime()
        {
            CourseName = "ASP.Net";
            CourseDuration = "70 hrs";
            Fee = 4500;

            Console.Write("Enter Starting Time  : ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter Ending Time  : ");
            int end = int.Parse(Console.ReadLine());
            Print(start, end);

        }
        public void Print(int start, int end)
        {
            Console.WriteLine();

            Console.WriteLine("Time : " + start + " to " + end);

            Console.WriteLine("Course : " + CourseName);
            Console.WriteLine("Duration : " + CourseDuration);
            Console.WriteLine("Fee : " + Fee);
            Console.WriteLine();

        }

    }
}
