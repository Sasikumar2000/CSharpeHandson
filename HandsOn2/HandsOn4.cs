using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn2
{
    class HandsOn4
    {

        public List<HandsOn4> MovieList = new List<HandsOn4>();
        public string MovieName { get; set; }
        public int ReleaseYear { get; set; }
        public string Category { get; set; }
        public string Director { get; set; }
        public string Actor1 { get; set; }
        public string Actor2 { get; set; }

        public HandsOn4(string MovieName, int ReleaseYear, string Category, string Director, string Actor1, string Actor2)
        {
            this.MovieName = MovieName;
            this.ReleaseYear = ReleaseYear;
            this.Category = Category;
            this.Director = Director;
            this.Actor1 = Actor1;
            this.Actor2 = Actor2;
        }

        public HandsOn4()
        {

        }
        public void GetCategory()
        {
            /*Console.Write("\nEnter a number of MovieName : ");
            string a = Console.ReadLine();

            Console.Write("Enter a number of ReleaseYear : ");
            int b = int.Parse(Console.ReadLine());
            
            Console.Write("Enter a number of Category    : ");
            string c = Console.ReadLine();
            
            Console.Write("Enter a number of Director    : ");
            string d = Console.ReadLine();
            
            Console.Write("Enter a number of Actor1      : ");
            string e = Console.ReadLine();
            
            Console.Write("Enter a number of Actor2      : ");
            string f = Console.ReadLine();*/


            //MovieList.Add(new HandsOn4(a, b, c, d, e, f));
            MovieList.Add(new HandsOn4("Thillu Mullu", 1981, "comedy", "K.Balachander", "Rajinikanth", "Madhavi"));
            MovieList.Add(new HandsOn4("Naan Sirithal ", 2020, "comedy", "Raana", "Hiphop Tamizha", "Iswarya Menon"));
            MovieList.Add(new HandsOn4("Doctor", 2021, "action", "Nelson", "SivaKarthikeyan", "Priyanka"));
            MovieList.Add(new HandsOn4("Oh My Kadavule", 2020, "romance", "Ashwath", "Ashok", "Rithika"));
            MovieList.Add(new HandsOn4("Seema Raja", 2018, "action", "Ponram", "SivaKarthikeyan", "Samantha"));
            MovieList.Add(new HandsOn4("Comali", 2019, "comedy", "Pradeep", "Ravi", "Kajal"));
            MovieList.Add(new HandsOn4(" Master", 2021, "action", "Lokesh", "Vijai", "Malavika"));
            MovieList.Add(new HandsOn4("Petta", 2019, "action", "Karthik", "Rajinikanth", "Simran"));
            MovieList.Add(new HandsOn4("96", 2018, "romance", "Govind Vasantha", "Vijai Sethupathi", "Trisha"));
            MovieList.Add(new HandsOn4("Alai Payuthey", 2000, "romance", "Mani Ratnam", "Madhavan", "Shalini"));
            MovieList.Add(new HandsOn4("Jillu oru kadhal", 2002, "romance", "Mani Ratnam", "Suriya", "Jothi"));


        }

        public void MM()
        {
            List<string> categoryObj = new List<string>();

            var result = from category in MovieList
                         select category.Category;
            foreach (var item in result)
            {
                categoryObj.Add(item);
            }

            List<string> unicat = categoryObj.Distinct().ToList();
            unicat.Sort();
            IDictionary<string, int> CountList = new Dictionary<string, int>();

            for (int i = 0; i < unicat.Count; i++)
            {
                int count = 0;
                //string temp =  categoryObj[i].ToString();
                for (int j = 0; j < categoryObj.Count; j++)
                {
                    if (unicat[i] == categoryObj[j])
                    {
                        count++;
                        
                    }
                }
                CountList.Add(unicat[i], count);
                

            }

            foreach (var item in CountList)
            {
                Console.WriteLine($"{item.Key}  {item.Value}");
            }
        }
    }
}
