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
            int returnToMainMenuOrExit = 1;
            bool invalidSelection;
            int userIsSearchingLibraryByAuthorTitleOrFullList;
            bool userIsSearchingLibraryByAuthorOrTitleIsValid;

            do
            {
                do
                {
                    Console.WriteLine("Welcome to the Grand Circus Library!\n Would you like to check in a book, check out a book, or see the full library? Please enter 1, 2, or 3:\n (1)Check In\n (2)Check Out\n (3)View library\n");
                    userWouldLikeToCheckInOrCheckOutIsValid = int.TryParse(Console.ReadLine(), out userWouldLikeToCheckInOrCheckOut);

                    if (!userWouldLikeToCheckInOrCheckOutIsValid || userWouldLikeToCheckInOrCheckOut < 1 || userWouldLikeToCheckInOrCheckOut > 3)
                    {
                        Console.WriteLine($"You have entered in an invalid selection. Please enter in 1, 2, or 3\n");
                    }
                } while (!userWouldLikeToCheckInOrCheckOutIsValid || userWouldLikeToCheckInOrCheckOut < 1 || userWouldLikeToCheckInOrCheckOut > 3);

                if (userWouldLikeToCheckInOrCheckOut == 1) // Returning a book - checking in
                {
                    do
                    {
                        Book correctBook;

                        Console.WriteLine($"\nLets return the book. Would you like to return the book by Author or by Title? Please enter 1 or 2 :\n(1)Search By Author\n(2)Search By Title\n");
                        userIsSearchingLibraryByAuthorOrTitleIsValid = int.TryParse(Console.ReadLine(), out userIsSearchingLibraryByAuthorTitleOrFullList);

                        if (userIsSearchingLibraryByAuthorTitleOrFullList == 1)
                        {
                            correctBook = library.SearchByAuthor();
                            if (correctBook != null)
                            {
                                library.CheckInBook(correctBook);
                            }
                        }

                        else if (userIsSearchingLibraryByAuthorTitleOrFullList == 2)
                        {
                            correctBook = library.SearchByTitle();
                            if (correctBook != null)
                            {
                                library.CheckInBook(correctBook);
                            }
                        }


                    } while (!userIsSearchingLibraryByAuthorOrTitleIsValid || userIsSearchingLibraryByAuthorTitleOrFullList < 1 || userIsSearchingLibraryByAuthorTitleOrFullList > 2);
                }

                if (userWouldLikeToCheckInOrCheckOut == 2) // Taking a book out - checking out
                {
                    Console.WriteLine($"\nWould you like to search the library by title, author, or see full list of books? Please enter 1, 2 or 3:\n(1)Full list of books\n(2)Search By Author\n(3)Search By Title\n");
                    userIsSearchingLibraryByAuthorOrTitleIsValid = int.TryParse(Console.ReadLine(), out userIsSearchingLibraryByAuthorTitleOrFullList);
                    do
                    {
                        Book correctBook;

                        if (userIsSearchingLibraryByAuthorTitleOrFullList == 1)
                        {
                            library.DisplayLibrary();
                            Console.WriteLine($"\nWould you like to check out a book by by title or by author? Please enter 1 or 2:\n(1)By Author \n(2)By Title\n");
                        }

                        else if (userIsSearchingLibraryByAuthorTitleOrFullList == 2)
                        {

                            correctBook = library.SearchByAuthor();
                            if (correctBook != null)
                            {
                                library.CheckOutBook(correctBook);
                            }

                            else if (userIsSearchingLibraryByAuthorTitleOrFullList == 3)
                            {
                                correctBook = library.SearchByTitle();
                                if (correctBook != null)
                                {
                                    library.CheckOutBook(correctBook);
                                }
                            }

                        } while (!userIsSearchingLibraryByAuthorOrTitleIsValid || userIsSearchingLibraryByAuthorTitleOrFullList < 1 || userIsSearchingLibraryByAuthorTitleOrFullList > 3) ;

                        if (userWouldLikeToCheckInOrCheckOut == 3) //Looking at the Full list
                        {
                            do
                            {
                                library.DisplayLibrary();
                                Console.WriteLine($"\nWould you like to go back to the main Menu or exit? Please enter 1 or 2:\n(1)Main Menu\n(2)Exit\n");
                                invalidSelection = int.TryParse(Console.ReadLine(), out returnToMainMenuOrExit);

                                invalidSelection = returnToMainMenuOrExit != 1 && returnToMainMenuOrExit != 2;
                            } while (invalidSelection);

                            if (returnToMainMenuOrExit == 2)
                            {
                                Console.WriteLine($"\nThank you for coming to the GC Library, please come again.");
                            }
                        }
                    } while (returnToMainMenuOrExit == 1);
                }
            } while (true);
        }
    }
}