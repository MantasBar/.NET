using System.Collections.Generic;
using System.Linq;
using ToDoList.Data;
using ToDoList.Dtos;
using ToDoList.Models;

namespace ToDoList.Services
{
    public class UserService
    {
        private DataContext _dataContext;

        public UserService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<UserDto> GetAll()
        {
            var entities = _dataContext.Users.ToList();
            var dtos = entities.Select(x => new UserDto
            {
                Id = x.Id,
                FullName = $"{x.FirstName} {x.LastName}"
            }).ToList();

            return dtos;
        }

        public void Add(User user)
        {
            user.CreatedUtc = System.DateTime.Now;
            _dataContext.Users.Add(user);
            _dataContext.SaveChanges();
        }
        public void Delete(int id)
        {
            var user = _dataContext.Users.FirstOrDefault(t => t.Id == id);
            _dataContext.Users.Remove(user);
            _dataContext.SaveChanges();
        }
    }
}
