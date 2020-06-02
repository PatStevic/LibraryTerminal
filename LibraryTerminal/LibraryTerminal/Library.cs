using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermKyle
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
            foreach (var book in _bookLibrary)
            {
                book.DisplayBook();
            }
        }

        public string SearchByTitle()
        {
            Console.Write("Enter a title keyword: ");
            string userInput = Console.ReadLine();

            for (int i = 0; i < _bookLibrary.Count; i++)
            {
                //split each title by a " " to seperate by word
                if (true  /*use contains function to search titles by user input*/)
                {
                    Console.WriteLine(_bookLibrary[i]);
                }
            }
            return ""; //FIX
        }

        public string SearchByAuthor()
        {
            Console.Write("Enter an author: ");
            string userInput = Console.ReadLine();
            
            string userResponse = "n";
            Book correctBook;
            bool bookFound = false;
            do
            {
                foreach (Book book in _bookLibrary)
                {
                    if (book.Author.Contains(userInput))
                    {
                        correctBook = book;
                        bookFound = true;
                        break;
                    }
                }
                if (!bookFound)
                {
                    Console.WriteLine("Book not found. Would you like to try again, y/n?");
                    userResponse = Console.ReadLine().ToLower();
                }
            } while (userResponse == "y");
            return; // We need to fix this")
        }



        public string ReturnBook()
        {
            return ""; //FIX
        }
    }
}
}


   