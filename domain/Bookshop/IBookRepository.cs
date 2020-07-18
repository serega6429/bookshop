using System;
using System.Collections.Generic;
using System.Text;

namespace Bookshop
{
    public interface IBookRepository
    {
        Book[] GetAllByTitle(string titlePart);
    }
}
