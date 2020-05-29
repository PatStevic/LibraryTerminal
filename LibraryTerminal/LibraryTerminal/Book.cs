using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryTerminal
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public BookStatus Status { get; set; }
        public DateTime CheckOutDate {get; set;}
        public DateTime DueDate { get; set; }

    }
}
