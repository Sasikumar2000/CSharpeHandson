using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    class MobileBrand
    {
        public int MobileID { get; set; }
        public string description { get; set; }

    }
    abstract class AbstractDemo
    {
        //abstract and non-abstract method

        public void MobileBrands()
        {
            MobileBrand[] mobileBrandObj = new MobileBrand[3];

            MobileBrand mobileBrand = new MobileBrand();

            mobileBrand.MobileID = 1;
            mobileBrand.description = "Somethink";
        }
       public abstract void camera();
        public abstract void ramconfig();
        public abstract void memorysetup();
        public abstract void processorsetup();

    }

    class Iphone13promax : AbstractDemo
    {
        public override void camera()
        {
            throw new NotImplementedException();
        }

        public override void memorysetup()
        {
            throw new NotImplementedException();
        }

        public override void processorsetup()
        {
            throw new NotImplementedException();
        }

        public override void ramconfig()
        {
            throw new NotImplementedException();
        }
    }
    class Iphone12promax
    {

    }
}
