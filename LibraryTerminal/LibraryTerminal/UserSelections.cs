using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryTerminal
{
    public class UserSelections
    {
        public UserSelections()
        {
        }

        public string MainMenuDiplayAndSearchOptions()
        {
            string searchOrDisplayUserInput;
            do
            {
                Console.WriteLine("Select from the following options to utilize the library. Enter the corresponding number:\n" +
                                "(1) Display the library\n" +
                                "(2) Search for book by author\n" +
                                "(3) Search for book by title keyword\n");
                searchOrDisplayUserInput = Console.ReadLine();

                if (!(searchOrDisplayUserInput == "1" || searchOrDisplayUserInput == "2" || searchOrDisplayUserInput == "3" || searchOrDisplayUserInput == "4"))
                {
                    Console.WriteLine("\nERROR: Please enter the a valid selection (1, 2, 3, or 4)\n");
                }

            } while (!(searchOrDisplayUserInput == "1" || searchOrDisplayUserInput == "2" || searchOrDisplayUserInput == "3" || searchOrDisplayUserInput == "4"));

            return searchOrDisplayUserInput;
        }

        public string MainMenuCheckOut_CheckIn()
        {
            string checkInCheckOutUserInput; 


        }
    }

}
