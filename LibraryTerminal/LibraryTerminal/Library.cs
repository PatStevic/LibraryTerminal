using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace LibraryTerminal
{
    class Library
    {
        private List<Book> _bookLibrary;
        public void LibraryOfBooks()
        {
            _bookLibrary = new List<Book>();
            _bookLibrary.Add(new Book { Title = "Discover Your Clifton Strengths", Author = "Tom Rath", Status = BookStatus.CheckedIn});
            _bookLibrary.Add(new Book { Title = "Thrifty Years", Author = "Hank Meijer", Status = BookStatus.CheckedIn });
            _bookLibrary.Add(new Book { Title = "Astrophysics For People In a Hurry", Author = "Neil DeGrasse Tyson", Status = BookStatus.CheckedIn });
            _bookLibrary.Add(new Book { Title = "The Tanning of America", Author = "Steve Stoute", Status = BookStatus.CheckedIn });
            _bookLibrary.Add(new Book { Title = "How To Win Friends and Influence People", Author = "Dale Carnegie", Status = BookStatus.CheckedIn });
            _bookLibrary.Add(new Book { Title = "The Siren", Author = "Tiffany Reisz", Status = BookStatus.CheckedIn });
            _bookLibrary.Add(new Book { Title = "A Game of Thornes", Author = "George R.R. Martin", Status = BookStatus.CheckedIn });
            _bookLibrary.Add(new Book { Title = "The Bit Picture", Author = "Shawn Carroll", Status = BookStatus.CheckedIn });
            _bookLibrary.Add(new Book { Title = "Gabriel's Inferno", Author = "Sylvain Reynard", Status = BookStatus.CheckedIn });
            _bookLibrary.Add(new Book { Title = "The End of Our Story", Author = "Mag Haston", Status = BookStatus.CheckedIn });
            _bookLibrary.Add(new Book { Title = "First Field Guide Amphibians", Author = "Bryan Cassie", Status = BookStatus.CheckedIn });
            _bookLibrary.Add(new Book { Title = "Strengths Based Leadership", Author = "Tom Rath", Status = BookStatus.CheckedIn });
            _bookLibrary.Add(new Book { Title = "Everything Happens For A Reason", Author = "Mira Kirshenbaum", Status = BookStatus.CheckedIn });
        }
    }
}
