using System.Collections.Generic;
using System.Linq;
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

        public List<Todo> GetAll()
        {
            return _dataContext.Todos.ToList();
        }

        public void Add(Todo todo)
        {
            todo.CreatedUtc = System.DateTime.Now;
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
