using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    class DoctorEntry
    {
        public void GetDoctoDteails()
        {
            int[] doctorId = new int[3];
            string[] doctorName = new string[3];
            string[] doctorAddress = new string[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter a DoctorName : ");
                doctorName[i] = Console.ReadLine();
                Console.Write("Enter a DoctorId : ");

                doctorId[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter a DoctorAddress : ");

                doctorAddress[i] = Console.ReadLine();
            }

            

            Console.WriteLine("Doctor Details");
            Console.WriteLine("Doctor Name : " + doctorName);


            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("Doctor Name : " + doctorName[i]);
                Console.WriteLine("Doctor Id : " + doctorId[i]);
                Console.WriteLine("Doctor Address : " + doctorAddress[i]);
               

            }
            Console.ReadKey();

        }
    }
}
