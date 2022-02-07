using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
	class Program
	{
		static void Main(string[] args)
		{
			// string hello = Console.ReadLine() ;
			/*// Console.WriteLine(hello);
			Maruthi carobj = new Maruthi();
			carobj.MarutiCarDetails();

			Swift swiftObj = new Swift();
			swiftObj.MarutiCarDetails();
			swiftObj.swiftCar();*/

			/*DoctorEntry doctorEntryObj = new DoctorEntry();
			doctorEntryObj.GetDoctoDteails();*/

			/*FileHandling fileHandlingObj = new FileHandling();
			fileHandlingObj.StoreHouseDetails();*/

			FileHandling fileHandlingObj = new FileHandling();
			fileHandlingObj.ReadDetails();
			Console.ReadKey();

		}
	}
}
