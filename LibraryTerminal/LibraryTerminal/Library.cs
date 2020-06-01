using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermKyle
{
    public class Library
    {
        private List<Book> _bookLibrary;
        public List<Book> LibraryOfBooks()
        {
            _bookLibrary = new List<Book>();
            _bookLibrary.Add(new Book("Discover Your Clifton Strengths", "Rath"));
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

            return _bookLibrary;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public BookStatus Status { get; set; }
    }
}