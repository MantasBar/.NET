using System.Collections.Generic;
using ToDoList.Models.Base;

namespace ToDoList.Models
{
    public class User : Entity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<Todo> Todos { get; set; }
    }
}
