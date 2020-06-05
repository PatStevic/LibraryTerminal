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

        public Book SearchByTitle()
        {
            string userWantsToContinue = "n";
            do
            {
                Console.Write("Enter a title keyword: ");
                string userInput = Console.ReadLine();

                List<Book> bookByTitle = new List<Book>();

                foreach (Book book in _bookLibrary)
                {
                    if (book.Title.Contains(userInput, StringComparison.OrdinalIgnoreCase))
                    {
                        bookByTitle.Add(book);
                    }
                }
                if (bookByTitle.Count == 0)
                {
                    Console.WriteLine("Book not found. Would you like to try again, y/n?");
                    userWantsToContinue = Console.ReadLine().ToLower();
                }
                else if (bookByTitle.Count == 1)
                {
                    return bookByTitle[0];
                }
                else if (bookByTitle.Count > 1)
                {
                    DisplayBooks(bookByTitle);
                    Console.WriteLine("Which book would you like to choose? (Please enter corresponding number)");
                    var userSelectBook = Console.ReadLine().ToLower();

                    var isBookValid = int.TryParse(userSelectBook, out var correctBook);
                    if (isBookValid && correctBook < bookByTitle.Count)
                    {
                        return bookByTitle[correctBook - 1];
                    }

                    Console.WriteLine("Invalid entry!");
                    userWantsToContinue = "y";
                }
            } while (userWantsToContinue == "y");
            return null;
        }

        public Book SearchByAuthor()
        {
            string userWantsToContinue = "n";
            do
            {
                Console.Write("Enter the author's last name: ");
                string userInput = Console.ReadLine();

                List<Book> bookByAuthor = new List<Book>();
                foreach (Book book in _bookLibrary)
                {
                    if (book.Author.Contains(userInput, StringComparison.OrdinalIgnoreCase))
                    {
                        bookByAuthor.Add(book);
                    }
                }
                if (bookByAuthor.Count == 0)
                {
                    Console.WriteLine("Book not found. Would you like to try again, y/n?");
                    userWantsToContinue = Console.ReadLine().ToLower();
                }
                else if (bookByAuthor.Count == 1)
                {
                    return bookByAuthor[0];
                }
                else if (bookByAuthor.Count > 1)
                {
                    DisplayBooks(bookByAuthor);
                    Console.WriteLine("Which book would you like to choose? (Please enter corresponding number)");
                    var userSelectBook = Console.ReadLine();

                    var isBookValid = int.TryParse(userSelectBook, out var correctBook);
                    if (isBookValid && correctBook < bookByAuthor.Count)
                    {
                        return bookByAuthor[correctBook - 1];
                    }

                    Console.WriteLine("Invalid entry!");
                    userWantsToContinue = "y";
                }
            } while (userWantsToContinue == "y");
            return null;
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



