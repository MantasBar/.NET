using ShopManagementApp.Data;
using ShopManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopManagementApp.Services
{
    public class ShopService
    {
        private DataContext _dataContext;

        public ShopService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        private List<Item> _items = new List<Item>()
        {
            new Item()
            {   Name = "Apple",
                ShopName = "Vaisiu pasaulis",
                ExpiryDate = DateTime.Today,
            }
        };

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
