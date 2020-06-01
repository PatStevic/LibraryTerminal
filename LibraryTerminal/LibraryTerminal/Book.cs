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

        public static void DisplayLibrary(List<Book> library)
        {

            foreach (var book in library)
            {
                DisplayBook(book);
            }
        }

        public static void DisplayBook(Book book)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Book Status: {book.Status})");
        }

        public static string SearchByAuthor(List<Book> library)
        {
            Console.Write("Enter an author: ");
            string userInput = Console.ReadLine();

            foreach (var book in library)
            {
                if (book.Author.ToLower() == userInput.ToLower())
                {
                    DisplayBook(book);
                }
            }
            return "";//Fix me
        }

        public static string SearchByTitle(List<Book> books)
        {
            Console.Write("Enter a title keyword: ");
            string userInput = Console.ReadLine();

            for (int i = 0; i < books.Count; i++)
            {
                //split each title by a " " to seperate by word
                if (true  /*use contains function to search titles by user input*/)
                {
                    Console.WriteLine(books[i]);
                }
            }
            return ""; //FIX
        }

        public static string ReturnBook(List<Book> books)
        {
            return ""; //FIX
        }
    }
}