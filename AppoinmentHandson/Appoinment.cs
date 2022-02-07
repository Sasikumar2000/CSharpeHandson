using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace AppoinmentHandson
{
   static class Appoinment
    {
        static List<DateTime> dateTimes1 = new List<DateTime>();
        public static DateTime Schedule()
        {
            CultureInfo ci = new CultureInfo("en-US");

            Console.Write("Enter your Date and Time : ");
            DateTime date = new DateTime();
            date = Convert.ToDateTime(Console.ReadLine(),ci);

            return date;
        }

        public static Boolean HasPassed(DateTime datep)
        {
            
            int count = 0;

            for (int i = 0; i < dateTimes1.Count; i++)
            {
                if (dateTimes1[i] == datep)
                {
                    Console.WriteLine("Appoinment Already Exit");
                    count++;
                }

                
               
            }
            
            if( count == 0)
            {
                dateTimes1.Add(datep);
                return true;
            }

            else
            {
                return false;
            }
            
        }

        public static Boolean IsAfternoonAppointment(DateTime date)
        {
            
            string datestr = date.ToString();
            string[] arrstr = datestr.Split(' ');
            string[] timearr = arrstr[1].Split(':');
            int time = Convert.ToInt32(timearr[0]);
            if( time >= 12 && time<18)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Book at afternoon..");
                return false;
            }
        }

        public static void Description(DateTime dateTime)
        {
            CultureInfo ci = new CultureInfo("en-US");
            Console.WriteLine($"You have an appointment on {dateTime.ToString("g", ci)}.");
        }
        public static void AnniversaryDate(DateTime dateTime)
        {
            string date = dateTime.ToString("dd/MM");
            if (date == "15-09")
            {
                Console.WriteLine("Anniversary date");
            }
            
        }


    }
}
