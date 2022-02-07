using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn2
{
    class HandsOn3
    {
        public string name { get; set; }
        public string productCode { get; set; }
        public string brandName { get; set; }
        public int stockLeft { get; set; }
        public double price { get; set; }
        public DateTime expiryDate { get; set; }
        public HandsOn3(string Name, string ProductCode, string BrandName,int Stockleft,double Price,DateTime ExpriyDate )
        {
            name = Name;
            productCode = ProductCode;
            brandName = BrandName;
            stockLeft = Stockleft;
            price = Price;
            expiryDate = ExpriyDate;
                
        }
        
        /*public void Hands3()
        {
            Console.Write("Enter your Product : ");
            string input = Console.ReadLine();
            string[] arr = input.Split(',');
            string a = arr[0];
            string b = arr[1];
            string c = arr[2];
            int d = Convert.ToInt32(arr[3]);
            double e = Convert.ToDouble(arr[4]);
            DateTime f = Convert.ToDateTime(arr[5]);

        }*/

        public bool CheckStock()
        {
            if(stockLeft == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckExpiryDate()
        {
            DateTime today =  DateTime.Now;
            if(expiryDate > today)
            {
                return true;

            }
            else
            {
                return false;

            }
        }
    }
}
