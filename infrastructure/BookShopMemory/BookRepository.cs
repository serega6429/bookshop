using Bookshop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookShopMemory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "ISBN12312-31321", "D. Knut", "Art of Programming"),
            new Book(2, "ISBN12312-31322", "M. Fowler", "Refactoring"),
            new Book(3, "ISBN12312-31323", "B. Kernighan", "C Programming Language")
        };

        public Book[] GetAllByIsbn(string isbn)
        {
            return books
               .Where(book => book.Isbn == isbn)
               .ToArray();
        }

        public Book[] GetAllByTitleOrAuthor(string titleOrAuthor)
        {
            return books
               .Where(book => book.Title.Contains(titleOrAuthor)
                           || book.Author.Contains(titleOrAuthor))
               .ToArray();
        }
    }
}