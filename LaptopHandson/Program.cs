using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptop1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hp hpobj = new Hp();
            Hcl hclobj = new Hcl();

            hpobj.price = 25000;
            hpobj.ram = "16GB";
            hpobj.processor = "intel core i7";
            hpobj.hardDrive = "2TB";

            hpobj.hpfun();

            hclobj.processor = "AMD";
            hclobj.price = 150000;

            hclobj.hclfun();
        }
    }
}
