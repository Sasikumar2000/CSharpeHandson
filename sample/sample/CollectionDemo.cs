using System;
using System.Collections.Generic;//generic
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; //non-generic

namespace sample
{
    class CollectionDemo
    {
        ArrayList arrayList = new ArrayList();
       
    }
    class Student
    {
        public void AddStudent()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Sasi");
            Console.WriteLine(arrayList[1]);

            Stack stackObj = new Stack();
            stackObj.Push("Caresoft");
            stackObj.Push(2021);
            Console.WriteLine(stackObj.Pop());
        }
    }
}
