using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


 // A method "ShowData" to display "I am a house, my area is 200 m2" (instead of 00, it will show the real surface).
 // The "House" will contain a door. Each door will have an attribute "color" (a string), and a method "ShowData"
 // wich will display "I am a door, my color is brown" (or whatever color it really is). Also, create a "GetDoor"
 // in the house. A "SmallApartment" is a subclass of House, with a present area of 50 m2. Also create a class Person,
 // with a name (string). Each person will have a house. The method "ShowData" for a person will display his/her name,
 // show the data of his/her house and the data of the door of that house. Write a Main to create a SmallApartment,
 // a person to live in it, and to show the data of the person.

namespace PersonHouse
{
    class House
    {
        public string area;
        public string color;
       public void ShowData()
        {
            Console.WriteLine("I am a house, my area is " + area);
            Console.WriteLine("I am a door, my color is " + color);
        }

       

    }
}
