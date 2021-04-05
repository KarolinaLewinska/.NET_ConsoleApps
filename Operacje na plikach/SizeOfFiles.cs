﻿using System;
using System.IO;

namespace SizeOfFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di;
            string userPath;
            long size = 0;

            Console.WriteLine("Podaj ścieżkę do katalogu");
            userPath = Console.ReadLine();
            di = new DirectoryInfo(userPath);
            
            foreach (var file in di.GetFiles())
            {
               size = size +  file.Length;
            }
            Console.WriteLine(size);
        }
    }
}
