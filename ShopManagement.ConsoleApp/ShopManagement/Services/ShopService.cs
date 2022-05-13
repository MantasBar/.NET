using ShopManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Services
{
    public class ShopService
    {
        private List<ShopItem> _items;
        public ShopService()
        {
            _items = new List<ShopItem>();
        }
        public void Add(string name, int quantity)
        {
            ShopItem item = new ShopItem()
            {
                Name = name,
                Quantity = quantity
            };
        }
        public void Remove(string name)
        {
            _items.Where(i => name != i.Name).ToList();
        }
        public List<ShopItem> ListAll()
        {
            return _items;
        }
        public void End()
        {
            Environment.Exit(0);
        }
    }
}
