using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LibraryTerminal
{
    public class BookRepository
    {
        static string filePath = Path.GetFullPath(@"..\..\..\..\SavedBookLibrary.txt"); // "@" is a string literal
        public static void WritetoFile(List<Book> booksToSave)
        {
            var cb = new StringBuilder();
            foreach (var item in booksToSave)
            {
                cb.AppendLine($"{item.Title},{item.Author}, {item.Status}, {item.DueDate}");
            }
            File.WriteAllText(filePath, cb.ToString());
        }

        public static List<Book> ReadFromFile() // line.split 
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            var returnListOfBooks = new List<Book>();

            foreach (string line in lines)
            {
                var splitDelimiter = line.Split(",");
                returnListOfBooks.Add(new Book
                {
                    Title = splitDelimiter[0],
                    Author = splitDelimiter[1],
                    Status = (BookStatus)Enum.Parse(typeof(BookStatus), splitDelimiter[2]),
                    DueDate = DateTime.Parse(splitDelimiter[3])
                }
                );
            }
            return returnListOfBooks;
        }
    }
}
