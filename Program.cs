using System;
using System.Collections.Generic;
using Library;

namespace Library 
{
    class Program 
    {
        static void Main (string[] args) 
        {

            // Create a few (4 or so) instances of books and use the method on your Library class to add them to the list of books in an instance of Library

            Book gameOfThrones = new Book() 
            {
                Title = "Game of Thrones",
                Author = "George R.R. Martin",
                ISBN = "ABC123"
            };
            Book lotr = new Book() 
            {
                Title = "Lord of the Rings",
                Author = "George R R Martin",
                ISBN = "DEF456",
                IsAvailable = false
            };
            Book twilight = new Book() 
            {
                Title = "Twilight",
                Author = "Stephanie Meyers",
                ISBN = "GHI789"
            };
            Book book1 = new Book() 
            {
                Title = "Book1",
                Author = "Author1",
                ISBN = "1A"
            };
            Book book2 = new Book() 
            {
                Title = "Book2",
                Author = "Author2",
                ISBN = "2B"
            };

            List<Book> books = new List<Book>() 
            {
                book1, book2
            };

            Library library = new Library(books, "George R.R. Martin Memorial Library", "G.R.R. Martin Street");

            library.AddToInventory(gameOfThrones);
            library.AddToInventory(lotr);
            library.AddToInventory(twilight);

            foreach(Book book in books)
            {
                if(book.IsAvailable)
                {
                    Console.WriteLine($"{book.Title}");
                }
            }

            if (library.IsAvailable("2B"))
            {
                Console.WriteLine("2B");
            } else
            {
                Console.WriteLine("Not 2B");
            }
        }
    }
}