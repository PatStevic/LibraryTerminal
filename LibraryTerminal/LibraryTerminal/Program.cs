using System;

namespace LibraryTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            int userWouldLikeToCheckInOrCheckOut;
            bool userWouldLikeToCheckInOrCheckOutIsValid;
            var library = new Library();
            //library.DisplayLibrary();
            //library.SearchByAuthor();

            var foundBook = library.SearchByTitle();

            do
            {
                Console.WriteLine("Welcome to the Grand Circus Library!\n Would you like to check in a book, check out a book, or see the full library? Please enter 1, 2, or 3:\n (1)Check In\n (2)Check Out\n (3)View library");
                userWouldLikeToCheckInOrCheckOutIsValid = int.TryParse(Console.ReadLine(), out userWouldLikeToCheckInOrCheckOut);

                if (!userWouldLikeToCheckInOrCheckOutIsValid || userWouldLikeToCheckInOrCheckOut < 1 || userWouldLikeToCheckInOrCheckOut > 3)
                {
                    Console.WriteLine($"You have entered in an invalid selection. Please enter in 1, 2, or 3");
                }
            } while (!userWouldLikeToCheckInOrCheckOutIsValid || userWouldLikeToCheckInOrCheckOut < 1 || userWouldLikeToCheckInOrCheckOut > 3);


            int userIsSearchingLibraryBy;
            bool userIsSearchingLibraryByIsValid;

            if (userWouldLikeToCheckInOrCheckOut == 1)
            {
                Console.WriteLine($"Which book would you like to return?\n");
                //display list of books that are checked out.
                //methood to check in book. 
                //break (in a do while loop)... Would you like to return another book, go back to main menu, or exit ;
            }


            if (userWouldLikeToCheckInOrCheckOut == 2)
            {
                do
                {
                    Console.WriteLine($"Would you like to search the library by title, author, or see full list of books? Please enter 1, 2 or 3:\n(1)Full list of books\n(2)Search By Author\n(3)Search By Title\n");
                    userIsSearchingLibraryByIsValid = int.TryParse(Console.ReadLine(), out userIsSearchingLibraryBy);

                    if (userIsSearchingLibraryBy == 1)
                    {
                        library.DisplayLibrary();
                    }

                    if (userIsSearchingLibraryBy == 2)
                    {
                    }

                } while (!userIsSearchingLibraryByIsValid || userIsSearchingLibraryBy < 1 || userIsSearchingLibraryBy > 3);
            }
            if (userWouldLikeToCheckInOrCheckOut == 3)
            {
                library.DisplayLibrary();
            }
        }
    }
}
