using ShopManagementApp.Data;
using ShopManagementApp.Dtos;
using ShopManagementApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShopManagementApp.Services
{
    public class ItemService
    {
        private DataContext _dataContext;

        public ItemService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public Item Get(string name)
        {
            return _dataContext.Items.SingleOrDefault(x => x.Name == name);
        }

        public List<Item> GetAll()
        {
            return _dataContext.Items.ToList();
        }

        public void Add(Item item)
        {
            _dataContext.Items.Add(item);
            _dataContext.SaveChanges();
        }

        public void Delete(string name)
        {
            var item = _dataContext.Items.FirstOrDefault(x => x.Name == name);
            _dataContext.Items.Remove(item);
            _dataContext.SaveChanges();
        }
    }
}
