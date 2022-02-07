using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    class Maruthi // parent class
    {
        public string carModel = "Maruti 2.0";
        public string carType = "XUV";
        public int modelYear = 2021;
        private string engineConfig = "z1.0";
        public void MarutiCarDetails() // using public to access where ever in project
        {
            Console.WriteLine(carModel); //printf('welcome')
            Console.WriteLine(carType);
            Console.WriteLine(modelYear);
            Console.WriteLine(engineConfig);
        }

    }

    class Swift : Maruthi // child class
    {
        public void swiftCar()
        {
            Console.WriteLine("Swift");
        }
    }
}
