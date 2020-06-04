using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryTerminal
{
    public class Library
    {
        private List<Book> _bookLibrary;

        public Library()
        {
            _bookLibrary = new List<Book>();
            _bookLibrary.Add(new Book("Thrifty Years", "Meijer"));
            _bookLibrary.Add(new Book("Astrophysics For People In a Hurry", "DeGrasse Tyson"));
            _bookLibrary.Add(new Book("The Tanning of America", "Stoute"));
            _bookLibrary.Add(new Book("How To Win Friends and Influence People", "Carnegie"));
            _bookLibrary.Add(new Book("The Siren", "Reisz"));
            _bookLibrary.Add(new Book("A Game of Thornes", "Martin"));
            _bookLibrary.Add(new Book("The Bit Picture", "Carroll"));
            _bookLibrary.Add(new Book("Gabriel's Inferno", "Reynard"));
            _bookLibrary.Add(new Book("The End of Our Story", "Haston"));
            _bookLibrary.Add(new Book("First Field Guide Amphibians", "Cassie"));
            _bookLibrary.Add(new Book("Strengths Based Leadership", "Rath"));
            _bookLibrary.Add(new Book("Everything Happens For A Reason", "Kirshenbaum"));
        }

        public void DisplayLibrary()
        {
            DisplayBooks(_bookLibrary);
        }

        public List<Book> SearchByTitle()
        {
            Console.Write("Enter a book Title: ");
            string userInputTitle = Console.ReadLine();

            var matchingBooks = new List<Book>();

            foreach (var book in _bookLibrary)
            {
                if (book.Title.Contains(userInputTitle))
                {
                    matchingBooks.Add(book);
                }
            }

            DisplayBooks(matchingBooks);
            /// Now ask the user to select a book

            return matchingBooks;

            //string userResponseByTitle = "n";
            //Book correctBook = null;
            //bool bookFound = false;
            //do
            //{
            //    foreach (Book book in _bookLibrary)
            //    {
            //        if (book.Title.Contains(userInputTitle))
            //        {
            //            correctBook = book;
            //            bookFound = true;
            //            break;
            //        }
            //    }
            //    if (!bookFound)
            //    {
            //        Console.WriteLine("Book not found. Would you like to try again, y/n?");
            //        userResponseByTitle = Console.ReadLine().ToLower();
            //    }
            //} while (userResponseByTitle == "y");
            //return correctBook;
        }

        public List<Book> SearchByAuthor()
        {
            Console.Write("Enter an author: ");
            string userInputAuthor = Console.ReadLine();

           //var matchingBooks = _bookLibrary.Where(book => book.Author.Contains(userInputAuthor)).ToList();

            // matchingBooks is now an List containing all books from the library where author name contains userInput

            // var cnt = 1;
            //foreach (var book in matchingBooks)
            // {
            //     Console.WriteLine($"Enter {cnt} for {book.Title}");
            //     cnt++;
            // }

            var matchingBooks = new List<Book>();

            foreach (var book in _bookLibrary)
            {
                if(book.Author.Contains(userInputAuthor))
                {
                    matchingBooks.Add(book);
                }
            }

            DisplayBooks(matchingBooks);
            /// Now ask the user to select a book

            return matchingBooks;

            //string userResponse = "n";
            //Book correctBook = null;
            //bool bookFound = false;
            //do
            //{
            //    foreach (Book book in _bookLibrary)
            //    {
            //        if (book.Author.Contains(userInputAuthor))
            //        {
            //            correctBook = book; 
            //            bookFound = true;
            //            break;
            //        }
            //    }
            //    if (!bookFound)
            //    {
            //        Console.WriteLine("Book not found. Would you like to try again, y/n?");
            //        userResponse = Console.ReadLine().ToLower();
            //    }
            //} while (userResponse == "y");
            //return correctBook;
        }

        public string ReturnBook()
        {
            return ""; //FIX
        }

        private void DisplayBooks(List<Book> books)
        {
            for (int i = 0; i < books.Count; i++)
            {
                Console.Write($"{i + 1} - ");
                books[i].DisplayBook();
            }
        }
    }
}



   