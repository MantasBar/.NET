using ShopManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopManagementApp.Services
{
    public class ShopService
    {
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
            return _items;
        }

        public void Add(Item item)
        {
            _items.Add(item);
        }

        public void Delete(string name)
        {
            _items = _items.Where(i => i.Name != name).ToList();
        }
    }
}
