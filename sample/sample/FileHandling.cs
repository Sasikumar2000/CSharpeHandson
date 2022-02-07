using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace sample
{
    class FileHandling
    {
        public void StoreHouseDetails()
        {
            FileStream fileStreamObj = new FileStream("D:\\file\\sample.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriterObj = new StreamWriter(fileStreamObj);
            streamWriterObj.WriteLine("Welcome Sasi");
            streamWriterObj.WriteLine("--------------");
            streamWriterObj.WriteLine("Your Content is Ready");
            streamWriterObj.Close();
            fileStreamObj.Close();


        } 
        public void ReadDetails()
        {
            Console.Write("Enter a file name : ");
            string path = Console.ReadLine();
            
            FileStream fileStreamobj = new FileStream("D:\\file\\"+path+".txt",FileMode.Open,FileAccess.Read);
            StreamReader streamReaderobj = new StreamReader(fileStreamobj);
            Console.WriteLine("ID\tSource\t\tDestination\tDate\t\tStatus\t\tNetwork");
            
            while ( streamReaderobj.Peek() > 0)
            {
                string line = streamReaderobj.ReadLine();
                if (line.Contains(":"))
                {
                    if (line.StartsWith("Date"))
                    {
                        string[] date = line.Split(':');
                        string[] datep = date[1].Split(' ');
                        Console.Write(datep[0]+ "\t");
                    }
                    else if (line.StartsWith("Network"))
                    {
                        string[] result = line.Split(':');
                        Console.WriteLine("\t"+result[1]);
                    }
                    else
                    {
                        string[] result = line.Split(':');
                        Console.Write(result[1]+ "\t");
                       
                    }
                   
                }
            }
        }
        /*public void ReadHouseDetails()
        {
            FileStream fileStreamObj = new FileStream("C:\\Test\\MyTempFile.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStreamObj);
            while (streamReaderObj.Peek() > 0)
            {
                string lineStr = streamReaderObj.ReadLine();
                if (lineStr.Contains(":"))
                {
                    string[] result = lineStr.Split(':');
                    Console.WriteLine(result[1]);
                }
                //if (line.Contains("G"))
                //{
                //    Console.WriteLine(line);
                //}
            }
        }*/

    }
}
