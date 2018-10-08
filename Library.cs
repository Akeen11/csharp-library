using System.Collections.Generic;

namespace Library 
{

    //     Make a Library class that has:
    // - Private List of Books (remember casing and naming convention here)
    // - Public Method to add a Book to the List of Books
    // - Public Address property
    // - Public Name property

    public class Library 
    {

        public Library (List<Book> initialInventory, string name, string address) 
        {
            _bookList = initialInventory;
            Name = name;
            Address = address;
        }

        public string Name { get; set; }
        public string Address { get; set; }

        private List<Book> _bookList;

        public void AddToInventory (Book book) 
        {
            _bookList.Add (book);
        }

        public void Checkout (string isbn, CardHolder cardHolder) 
        {
            foreach (Book book in _bookList) 
            {
                if (book.ISBN == isbn && book.IsAvailable) 
                {
                    cardHolder.CheckoutBook(book);
                    book.IsAvailable = false;
                } 
            }
        }

        public bool IsAvailable(string isbn)
        {
            foreach(Book book in _bookList)
            {
                if(book.ISBN == isbn)
                {
                    return book.IsAvailable;
                }
            }
            return false;
        }
    }
}