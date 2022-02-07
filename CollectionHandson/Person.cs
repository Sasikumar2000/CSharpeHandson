using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection
{
    class Person
    {
        public void PersonData()
        {
            ArrayList listName = new ArrayList();
            ArrayList listAge = new ArrayList();


            Console.Write("Enter a Number of Details : ");
            int size =Convert.ToInt32(Console.ReadLine());

            for( int i = 0; i < size; i++)
            {
                Console.Write("Enter a Name : ");
                listName.Add(Console.ReadLine());

                Console.Write("Enter a age : ");
                listAge.Add(Console.ReadLine());
            }

            for ( int i =0; i < listName.Count; i++)
            {
                Console.WriteLine(listName[i] + " - " + listAge[i]);
            }

        }
    }
}

