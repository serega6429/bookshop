using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookshop;
using Microsoft.AspNetCore.Mvc;

namespace BookShopWeb.Controllers
{
    public class SearchController : Controller
    {
        private readonly IBookRepository bookRepository;

        public SearchController(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }
        public IActionResult Index(string query)
        {
            var books = bookRepository.GetAllByTitle(query);

            return View(books);
        }
    }
}