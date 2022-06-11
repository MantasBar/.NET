using Microsoft.AspNetCore.Mvc;
using TodoList.Dtos;
using ToDoList.Services;

namespace ToDoList.Controllers
{
    public class ToDoController : Controller
    {
        private TodoService _todosService;
        private UserService _userService;

        public ToDoController(TodoService todosService, UserService userService)
        {
            _todosService = todosService;
            _userService = userService;
        }

        public IActionResult Index()
        {
            var todos = _todosService.GetAll();
            return View(todos);
        }

        [HttpGet]
        public IActionResult Add()
        {
            CreateTodoDto todo = new CreateTodoDto();
            todo.Todo = new Models.Todo();
            todo.Users = _userService.GetAll();
            return View(todo);
        }

        [HttpPost]
        public IActionResult Add(CreateTodoDto createTodo)
        {
            _todosService.Add(createTodo.Todo);
            return RedirectToAction("Index");
        }

        public IActionResult Delete (string name)
        {
            _todosService.Delete(name);
            return RedirectToAction("Index");
        }
    }
}
