using ToDoList.Data;
using ToDoList.Models;
using ToDoList.Services.Base;

namespace ToDoList.Services
{
    public class CategoryService : BaseService<Category>
    {
        public CategoryService(DataContext dataContext) : base(dataContext)
        {

        }

        public void Add(Category category)
        {
            category.CreatedUtc = System.DateTime.Now;
            _dataContext.Categories.Add(category);
            _dataContext.SaveChanges();
        }
    }
}
