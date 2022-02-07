using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            House hobj = new House();
            Apart aobj = new Apart();
            Person pobj = new Person();
            
            hobj.area = "200 m2";
            aobj.area = "50 m2";
            pobj.color = "Green";
            
            Console.WriteLine("Enter Person Area : ");
            pobj.area = Console.ReadLine();

          //  pobj.ShowData();
            pobj.Pname();
            pobj.GetDoor();
            pobj.ShowData();
          //  aobj.ShowData();
          //  hobj.ShowData();
        }
    }
}
