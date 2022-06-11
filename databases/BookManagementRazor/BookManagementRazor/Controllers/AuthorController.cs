using BookManagementRazor.Dtos;
using BookManagementRazor.Models;
using BookManagementRazor.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BookManagementRazor.Controllers
{
    public class AuthorController : Controller
    {
        private AuthorService _authorService;
        private BookService _bookService;

        public AuthorController(AuthorService authorService, BookService bookService)
        {
            _authorService = authorService;
            _bookService = bookService;
        }

        public IActionResult Index()
        {
            List<AuthorDto> authors = _authorService.GetAll();
            return View(authors);
        }

        [HttpGet]
        public IActionResult Add()
        {
            Author author = new();
            return View(author);
        }

        [HttpPost]
        public IActionResult Add(Author author)
        {
            _authorService.Add(author);
            return RedirectToAction("Index");
        }

        public IActionResult Remove(int id)
        {
            _authorService.Remove(id);
            return RedirectToAction("Index");
        }
    }
}
