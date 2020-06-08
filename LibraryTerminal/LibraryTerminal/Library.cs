﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LibraryTerminal
{
    public class Library
    {
        private List<Book> _bookLibrary;
        public List<Book> _checkedOutBooks;
        public List<Book> _checkedInBooks;
        static string filePath = System.IO.Path.GetFullPath(@"..\..\..\..\SavedBookLibrary.txt"); // "@" is a string literal
        public Library()
        {
<<<<<<< HEAD
            if (!File.Exists(filePath))
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
                BookRepository.WritetoFile(_bookLibrary);
            }
            _bookLibrary = BookRepository.ReadFromFile();
=======
            _bookLibrary = new List<Book>();
            _bookLibrary.Add(new Book("Thrifty Years", "Meijer"));
            _bookLibrary.Add(new Book("Astrophysics For People In a Hurry", "DeGrasse Tyson"));
            _bookLibrary.Add(new Book("The Tanning of America", "Stoute"));
            _bookLibrary.Add(new Book("How To Win Friends and Influence People", "Carnegie"));
            _bookLibrary.Add(new Book("The Siren", "Reisz"));
            _bookLibrary.Add(new Book("A Game of Thrones", "Martin"));
            _bookLibrary.Add(new Book("The Bit Picture", "Carroll"));
            _bookLibrary.Add(new Book("Gabriel's Inferno", "Reynard"));
            _bookLibrary.Add(new Book("The End of Our Story", "Haston"));
            _bookLibrary.Add(new Book("First Field Guide Amphibians", "Cassie"));
            _bookLibrary.Add(new Book("Strengths Based Leadership", "Rath"));
            _bookLibrary.Add(new Book("Everything Happens For A Reason", "Kirshenbaum"));
>>>>>>> ed87e0602ab131909d06ad4c5c0fd4b020c8bc9b
        }

        private void DisplayBooks(List<Book> books)
        {
            for (int i = 0; i < books.Count; i++)
            {
                Console.Write($"{i + 1} - ");
                books[i].DisplayBook();
            }
        }

        public void DisplayLibrary()
        {
            DisplayBooks(_bookLibrary);
        }

        public Book SearchByTitle()
        {
            string userWantsToContinue = "n";
            do
            {
                Console.Write("Enter a title keyword: ");
                string userInput = Console.ReadLine();

                List<Book> bookByTitle = new List<Book>();

                foreach (Book book in _bookLibrary)
                {
                    if (book.Title.Contains(userInput, StringComparison.OrdinalIgnoreCase))
                    {
                        bookByTitle.Add(book);
                    }
                }
                if (bookByTitle.Count == 0)
                {
                    do
                    {
                        Console.Write("Book not found. Would you like to try again? (y/n): ");
                        userWantsToContinue = Console.ReadLine().ToLower();
                        if (userWantsToContinue != "y" || userWantsToContinue != "n")
                        {
                            Console.WriteLine("Invalid entry. Please enter y/n");
                        }
                    } while (userWantsToContinue != "y" || userWantsToContinue != "n");
                }
                else if (bookByTitle.Count == 1)
                {
                    Console.WriteLine($"{bookByTitle[0].Title} by {bookByTitle[0].Author}\n");
                    return bookByTitle[0];
                }
                else if (bookByTitle.Count > 1)
                {
                    DisplayBooks(bookByTitle);
                    
                    Console.Write("Which book would you like to choose? (Please enter corresponding number): ");
                    var userSelectBook = Console.ReadLine().ToLower();

                    var isBookValid = int.TryParse(userSelectBook, out var correctBook);
                    if (isBookValid && correctBook < bookByTitle.Count)
                    {
                        return bookByTitle[correctBook - 1];
                    }

                    Console.WriteLine("Invalid entry!\n");
                    userWantsToContinue = "y";
                }
            } while (userWantsToContinue == "y");
            return null;
        }

        public Book SearchByAuthor()
        {
            string userWantsToContinue = "n";
            do
            {
                Console.Write("Enter the author's last name: ");
                string userInput = Console.ReadLine();

                List<Book> bookByAuthor = new List<Book>();
                foreach (Book book in _bookLibrary)
                {
                    if (book.Author.Contains(userInput, StringComparison.OrdinalIgnoreCase))
                    {
                        bookByAuthor.Add(book);
                    }
                }
                if (bookByAuthor.Count == 0)
                {
                    do
                    {
                        Console.Write("Book not found. Would you like to try again? (y/n): ");
                        userWantsToContinue = Console.ReadLine().ToLower();
                        if (userWantsToContinue != "y" || userWantsToContinue != "n")
                        {
                            Console.WriteLine("Invalid entry. Please enter y/n");
                        }
                    } while (userWantsToContinue != "y" || userWantsToContinue != "n");
                }
                else if (bookByAuthor.Count == 1)
                {
                    Console.WriteLine($"{bookByAuthor[0].Title} by {bookByAuthor[0].Author}\n");
                    return bookByAuthor[0];   
                }
                else if (bookByAuthor.Count > 1)
                {
                    DisplayBooks(bookByAuthor);

                    Console.Write("Which book would you like to choose? (Please enter corresponding number): ");
                    var userSelectBook = Console.ReadLine();

                    var isBookValid = int.TryParse(userSelectBook, out var correctBook);

                    if (isBookValid && correctBook < bookByAuthor.Count)
                    {
                        return bookByAuthor[correctBook - 1];
                    }

                    Console.WriteLine("Invalid entry!\n");
                    userWantsToContinue = "y";
                }
            } while (userWantsToContinue == "y");
            return null;
        }

        public void CheckInBook(Book book)
        {
            string userDecision;
            bool valid;

            do
            {
                Console.Write($"Would you like to check in {book.Title}? (y/n): ");
                userDecision = Console.ReadLine().ToLower();
                valid = userDecision != "y" && userDecision != "n";
                if (valid)
                    Console.WriteLine("Invalid Entry, Please try again!");
            } while (valid);

            if (userDecision == "y" || book.Status == BookStatus.CheckedOut)
            {
                book.Status = BookStatus.CheckedIn;
<<<<<<< HEAD
                BookRepository.WritetoFile(_bookLibrary);
                Console.WriteLine($"{book.Title} has been checked back in");
=======
                //save file
                Console.WriteLine($"{book.Title} has been checked back in\n");
>>>>>>> ed87e0602ab131909d06ad4c5c0fd4b020c8bc9b
            }
            else if (userDecision == "y" || book.Status == BookStatus.CheckedIn)
            {
                Console.WriteLine($"Sorry, {book.Title} is already checked in\n");
            }
        }

        public void CheckOutBook(Book book)
        {
            string userDecision;
            bool valid;
            do
            {
                Console.Write($"Would you like to check out {book.Title}? (y/n): ");
                userDecision = Console.ReadLine().ToLower();
                valid = userDecision != "y" && userDecision != "n";
                if (valid)
                    Console.WriteLine("Invalid Entry, Please try again!");
            } while (valid);

            if (userDecision == "y" || book.Status == BookStatus.CheckedIn)
            {
                book.Status = BookStatus.CheckedOut;
<<<<<<< HEAD
                DateTime DueDate = DateTime.UtcNow.AddDays(14);

                BookRepository.WritetoFile(_bookLibrary);
                Console.WriteLine($"{book.Title} has been checked out. The due date is {book.DueDate}");
=======
                DateTime DueDate = DateTime.UtcNow.AddDays(14); //date not being added
                //save file
                Console.WriteLine($"{book.Title} has been checked out. The due date is {book.DueDate}\n");
>>>>>>> ed87e0602ab131909d06ad4c5c0fd4b020c8bc9b
            }
            else if (userDecision == "y" || book.Status == BookStatus.CheckedOut)
            {
                Console.WriteLine($"Sorry, {book.Title} is already checked out\n");
            }
        }
    }
}



