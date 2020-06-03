using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryTerminal
{
    public class Validate
    {
        public Validate()
        {
        }

        public string MainMenuSelect()
        {
            string input;
            do
            {
                Console.WriteLine("Select from the following options to utilize the library. Enter the corresponding number:\n" +
                                "(1) Display the library\n" +
                                "(2) Search for book by author\n" +
                                "(3) Search for book by title keyword\n");
                input = Console.ReadLine();

                if (!(input == "1" || input == "2" || input == "3" || input == "4"))
                {
                    Console.WriteLine("\nERROR: Please enter the a valid selection (1, 2, 3, or 4)\n");
                }

            } while (!(input == "1" || input == "2" || input == "3" || input == "4"));

            return input;
        }
    }
}
