﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            FileHandling fileHandlingObj = new FileHandling();
            fileHandlingObj.Store();
            Console.ReadKey();
        }
    }
}