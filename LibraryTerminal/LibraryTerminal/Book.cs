using System;
using System.Collections.Generic;
using System.Linq;


namespace LibraryTerminal
{
    public class Book
    {
        public Book(List<Book> bookLibrary)
        {
        }

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


        public void BookCheckIn(Book book)
        {
            book.Status = BookStatus.CheckedIn;
            //save text file
        }

        public void BookCheckOut(Book book)
        {
            book.Status = BookStatus.CheckedOut;

            DateTime DueDate = DateTime.UtcNow.AddDays(14);
            //save text file

            Console.WriteLine($"The current date is {DueDate}");
        }


        public void DisplayBook()
        {

            if (Status == BookStatus.CheckedIn)
                Console.WriteLine($"Title:{Title}\nAuthor:{Author},\nBook Status:{Status}\nBook Due Date: n/a");

            if (Status == BookStatus.CheckedOut)

                Console.WriteLine($"Title:{Title}\nAuthor:{Author},\nBook Status:{Status}\nBook Due Date:{DueDate}");
        }
    }
}

