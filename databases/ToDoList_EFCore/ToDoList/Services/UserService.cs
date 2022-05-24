﻿using System.Collections.Generic;
using System.Linq;
using ToDoList.Data;
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

        public List<User> GetAll()
        {
            return _dataContext.Users.ToList();
        }

        public void Add(User user)
        {
            _dataContext.Users.Add(user);
            _dataContext.SaveChanges();
        }
    }
}
