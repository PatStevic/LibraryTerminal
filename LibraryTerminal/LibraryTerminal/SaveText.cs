using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LibraryTerminal
{
    class SaveText
    {
        static void Main2(string[] args)
        {
            String filePath = "LibraryList.txt";

            WritetoFile(filePath);
            ReadFromFile(filePath);

            ReadFromFile(filePath); //static method do not have to create an object
        }

        public static void ReadFromFile(string filePath)
        {
            StreamReader listReader = new StreamReader(filePath);
            while (!listReader.EndOfStream)
            {
                Console.WriteLine(listReader.ReadLine());
                //writing contents of file to console
            }

            listReader.Close();
        }

        public static void WritetoFile(string filePath)
        {
            StreamWriter writer = new StreamWriter(filePath, true);
            String temp = String.Empty;
            do
            {
                // prompt user ask for name and store in temp var and pass to 
                //streawriter object
                Console.Write("Enter a book name [-1 to exit]: ");
                temp = Console.ReadLine(); //this will be passed into writer object
                if (temp != "-1")
                {
                    writer.WriteLine(temp);
                }

            } while (temp != "-1"); //the user has to enter -1 to exit the loop, but the 
                                    //-1 will end up in text file. need to modify, not sure we want this as an exit option

            writer.Close(); //never forget to close it
        }

    }
}

