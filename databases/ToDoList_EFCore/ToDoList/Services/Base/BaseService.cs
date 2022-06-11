using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Data;
using ToDoList.Models.Base;

namespace ToDoList.Services.Base
{
    public class BaseService<T>
        where T : Entity
    {
        protected DataContext _dataContext;

        public BaseService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Create(T entity)
        {
            entity.CreatedUtc = DateTime.Now;
            _dataContext.Set<T>().Add(entity);
            _dataContext.SaveChanges();
        }
    }
}
