using BookManagement.Dtos;
using BookManagement.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookManagement.Controllers
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
            var books = _bookService.GetAll();
            return View(books);
        }

        [HttpGet]
        public IActionResult Add()
        {
            BookDto book = new();
            book.Author = _authorService.GetAll();
            return View(book);
        }

        [HttpPost]
        public IActionResult Add(BookDto bookDto)
        {
            _bookService.Add(bookDto);
            return RedirectToAction("Index");
        }

        public IActionResult Remove(string name)
        {
            _bookService.Remove(name);
            return RedirectToAction("Index");
        }
    }
}
