using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LibraryTerminal
{
    public class SavingLibraryBooksToTextFile
    {
        static void TextFileReadWrite(string[] args)
        {
            string filePath = @"LibraryTerminal\LibraryTerminal\LibraryTerminal\bin\Debug\netcoreapp3.1\SavedBookLibrary.txt"; // @ is a string literal

            WritetoFile(filePath);
            ReadFromFile(filePath);
            Console.ReadLine();
        }

        public static void WritetoFile(string filePath)
        {

        }
        public static void ReadFromFile(string filePath)
        {
            File.ReadAllLines(filePath);
        }



    }
}

