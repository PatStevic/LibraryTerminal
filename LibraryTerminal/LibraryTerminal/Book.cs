using System;
using System.Collections.Generic;
using System.Linq;


namespace LibraryTerminal
{
    public class Book
    {
        public Book() { }
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            Status = BookStatus.CheckedIn;
            DueDate = DateTime.MinValue;
        }

        // var book1 = new Book("", "", 12);
        //book1.Title
        //possibly later create a unique id to identify book

        public string Title { get; set; }
        public string Author { get; set; }
        public BookStatus Status { get; set; }
        public DateTime DueDate { get; set; }



        public void DisplayBook()
        {

            if (Status == BookStatus.CheckedIn)
                Console.WriteLine($"Title:{Title}\nAuthor:{Author}\nBook Status:{Status}\nBook Due Date: n/a\n");

            if (Status == BookStatus.CheckedOut)

                Console.WriteLine($"Title:{Title}\nAuthor:{Author}\nBook Status:{Status}\nBook Due Date:{DueDate}\n");
        }
    }
}

