using BookManagementRazor.Models;
using Microsoft.EntityFrameworkCore;

namespace BookManagementRazor.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
