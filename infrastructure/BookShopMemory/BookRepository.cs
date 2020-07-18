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
            new Book(1, "Art of Progaramming"),
            new Book(2, "Refactoring"),
            new Book(3, "C Programming Language")
        };

        public Book[] GetAllByTitle(string titlePart)
        {
            return books
                .Where(book => book.Title.Contains(titlePart))
                .ToArray();
        }
    }
}