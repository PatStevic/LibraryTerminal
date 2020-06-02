using System;
using System.Collections.Generic;
using System.Linq;


namespace MidtermKyle
{
    public class Book
    {
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            Status = BookStatus.CheckedIn;
        }

        // var book1 = new Book("", "", 12);
        //book1.Title

        public string Title { get; set; }
        public string Author { get; set; }
        public BookStatus Status { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime DueDate { get; set; }

       

        public void DisplayBook()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Book Status: {Status})");
        }
    }
}
