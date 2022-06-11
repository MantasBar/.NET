using System;

namespace ToDoList.Models.Base
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public DateTime CreatedUtc { get; set; }
    }
}
