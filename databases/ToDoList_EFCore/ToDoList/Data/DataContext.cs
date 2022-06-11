using Microsoft.EntityFrameworkCore;
using ToDoList.Models;

namespace ToDoList.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Category> Categories { get; set; }
        
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
