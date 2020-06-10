using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryTerminal
{
    class Test
    {
        public void BookCheckIn(Book book)
        {
            book.Status = BookStatus.CheckedIn;
        }

        public void BookCheckOut(Book book)
        {
            book.Status = BookStatus.CheckedOut;

            string date = DateTime.UtcNow.ToString("MM-dd-yyyy");
            Console.WriteLine($"The due date is {date + 14}");
        }


    }
}
