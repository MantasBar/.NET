using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Models;
using ToDoList.Services;

namespace ToDoList.Controllers
{
    public class ToDoController : Controller
    {
        private TodoService _todosService;

        public ToDoController(TodoService todosService)
        {
            _todosService = todosService;
        }

        public IActionResult Index()
        {
            var todos = _todosService.GetAll();
            return View(todos);
        }

        [HttpGet]
        public IActionResult Add()
        {
            Todo todo = new Todo();
            return View();
        }

        [HttpPost]
        public IActionResult Add(Todo todo)
        {
            _todosService.Add(todo);
            return RedirectToAction("Index");
        }

        public IActionResult Delete (string name)
        {
            _todosService.Delete(name);
            return RedirectToAction("Index");
        }
    }
}
