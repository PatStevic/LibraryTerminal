using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryTerminal
{
    public class Book
    {
        public Book(Title title, Author author, Status status)
        {
        Title = title;
        Author = author;
        Status = status; 
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string Status { get; set; }

    }
}
