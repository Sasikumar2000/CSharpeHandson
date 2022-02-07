using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    class FileHandling
    {
        public void Store()
        {
            int o;
            
            do
            {
                Console.WriteLine("1.Add to new File.");
                Console.WriteLine("2.Add to Existing File.");
                Console.WriteLine("3.Exit.");
                Console.WriteLine(" ");


                Console.Write("Choose the option : ");
                o = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");


                if (o < 3)
                {
                    Console.Write("Enter a File Name : ");
                    string fname = Console.ReadLine();
                    Console.WriteLine(" ");

                    string path = "D:\\File\\" + fname + ".txt";
                    FileStream fileStreamObj = new FileStream(path, FileMode.Append, FileAccess.Write);
                    StreamWriter streamWriterObj = new StreamWriter(fileStreamObj);
                    
                    Console.Write("Enter a number of Call records : ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" ");


                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("Enter a Id : ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        streamWriterObj.WriteLine("Id : " + id);

                        Console.Write("Enter source no : ");
                        long source = Convert.ToInt64(Console.ReadLine());
                        streamWriterObj.WriteLine("Source : " + source);

                        Console.Write("Enter a Designation : ");
                        long designation = Convert.ToInt64(Console.ReadLine());
                        streamWriterObj.WriteLine("Designation : " + designation);

                        DateTime dt = DateTime.Now;
                        streamWriterObj.WriteLine("Date : " + dt.ToString("f"));

                        Console.Write("Enter a Status : ");
                        string status = Console.ReadLine();
                        streamWriterObj.WriteLine("Status : " + status);

                        Console.Write("Enter a Network : ");
                        string network = Console.ReadLine();
                        streamWriterObj.WriteLine("Network : " + network);

                        streamWriterObj.WriteLine(" ");


                        Console.WriteLine(" ");


                    }
                    streamWriterObj.Close();
                    fileStreamObj.Close();

                    Console.WriteLine("Record Saved Sucessfully...");
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine("Exiting...");

                }
            } while (o != 3);
        }
    }
}
