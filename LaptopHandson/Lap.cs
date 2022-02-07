using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptop1
{
    class Lap //parent class
    {
        
        public int price;
        public string processor;
        public string ram;
        public string hardDrive;
       

    }

    class Hp : Lap
    {
        string name = "hp";
        public void hpfun()
        {
            Console.WriteLine(name);
            Console.WriteLine(ram);
            Console.WriteLine(hardDrive);
            Console.WriteLine(processor);
        }

    }
    class Hcl : Lap
    {
        string name = "hcl";
        public void hclfun()
        {
            Console.WriteLine(name);
            Console.WriteLine(ram);
            Console.WriteLine(hardDrive);
            Console.WriteLine(processor);
        }
    }

    class Del : Lap
    {
    }

}
