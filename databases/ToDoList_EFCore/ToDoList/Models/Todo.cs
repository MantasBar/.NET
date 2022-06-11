using System;
using ToDoList.Models.Base;

namespace ToDoList.Models
{
    public class Todo : NamedEntity
    {
        public string Category { get; set; }
        public User User { get; set; }
        public int? UserId { get; set; }
    }
}
