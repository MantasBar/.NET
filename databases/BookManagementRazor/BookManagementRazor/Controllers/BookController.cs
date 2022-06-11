using BookManagementRazor.Dtos;
using BookManagementRazor.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BookManagementRazor.Controllers
{
    public class BookController : Controller
    {
        private BookService _bookService;
        private AuthorService _authorService;

        public BookController(BookService bookService, AuthorService authorService)
        {
            _bookService = bookService;
            _authorService = authorService;
        }

        public IActionResult Index()
        {
            List<BookDto> books = _bookService.GetAll();
            return View(books);
        }

        [HttpGet]
        public IActionResult Add()
        {
            BookDto book = new();
            book.Authors = _authorService.GetAll();
            return View(book);
        }

        [HttpPost]
        public IActionResult Add(BookDto bookDto)
        {
            _bookService.Add(bookDto);
            return RedirectToAction("Index");
        }

        public IActionResult Remove(int id)
        {
            _bookService.Remove(id);
            return RedirectToAction("Index");
        }
    }
}
