using System;


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
            DueDate = DateTime.Today;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public BookStatus Status { get; set; }
        public DateTime DueDate { get; set; }

        public void DisplayBook()
        {

            if (Status == BookStatus.CheckedIn)
                Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nBook Status: {Status}\nBook Due Date: n/a\n");

            if (Status == BookStatus.CheckedOut)
                Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nBook Status: {Status}\nBook Due Date: {DueDate}\n");
        }
    }
}