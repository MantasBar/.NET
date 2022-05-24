using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Data;
using ToDoList.Models;

namespace ToDoList.Services
{
    public class TodoService
    {
        private DataContext _dataContext;

        public TodoService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        private List<Todo> _todos = new List<Todo>()
        {
            new Todo()
            {
                Category = "Studying",
                CreatedUtc = System.DateTime.Now,
                Name = "Study Programming"
            },
            new Todo()
            {
                Category = "House",
                CreatedUtc = System.DateTime.Now,
                Name = "Clean Room"
            }
        };

        public List<Todo> GetAll()
        {
            return _dataContext.Todos.ToList();
        }

        public void Add(Todo todo)
        {
            _dataContext.Todos.Add(todo);
            _dataContext.SaveChanges();
        }

        public void Delete(string name)
        {
            var todo = _dataContext.Todos.FirstOrDefault(t => t.Name == name);
            _dataContext.Todos.Remove(todo);
            _dataContext.SaveChanges();
        }
    }
}
