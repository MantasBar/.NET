using BookManagement.Dtos;
using BookManagement.Models;
using BookManagement.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Controllers
{
    public class AuthorController : Controller
    {
        private AuthorService _authorService;

        public AuthorController(AuthorService authorService)
        {
            _authorService = authorService;
        }

        public IActionResult Index()
        {
            var books = _authorService.GetAll();
            return View(books);
        }

        [HttpGet]
        public IActionResult Add()
        {
            AuthorDto author = new();
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
