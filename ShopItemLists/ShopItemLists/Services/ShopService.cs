using ShopItemLists.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopItemLists.Services
{
    public class ShopService
    {
        private Customer _customer = new Customer(); 
        private List <ShopItem> _items = new List<ShopItem>();
        public ShopService()
        {
            _items = new List<ShopItem>();
            _customer = new Customer();
        }

        public void Add(string name, decimal price, int quantity)
        {
            if (_items.Any(i => i.Name == name))
            {
                throw new ArgumentException("Item already exists");
            }

            ShopItem item = new ShopItem
            {
                Name = name,
                Price = price,
                Quantity = quantity
            };

            _items.Add(item);
        }

        public void Remove(string name)
        {
            if (!_items.Any(i => i.Name == name))
            {
                throw new ArgumentException("The item does not exist");
            }
                
            _items.RemoveAll(i => i.Name != name);
        }

        public List<ShopItem> GetAll()
        {
            return _items;
        }

        public List<ShopItem> GetCart()
        {
            return _customer.Cart;
        }

        public void Set(string name, int quantity)
        {
            ShopItem item = _items.Single(i => i.Name == name);

            if (item == null)
            {
                throw new Exception("The item is not found");
            }

            item.Quantity = quantity;
        }

        public Decimal GetBalance()
        {
            return _customer.Balance;
        }

        public void Topup(decimal top)
        {
            _customer.Balance += top;
        }

        public void Buy(string name, int quantity)
        {
            ShopItem item = _items.FirstOrDefault(i => i.Name == name);

            if (item == null)
            {
                throw new ArgumentException("The item does not exist");
            }

            if (item.Quantity < quantity)
            {
                throw new ArgumentException("not enough of the item");
            }

            decimal price = item.Price * quantity;

            if(price > _customer.Balance)
            {
                throw new ArgumentException("not enough balance");
            }

            item.Quantity -= quantity;
            _customer.Balance -= price;

            _customer.Cart.Add(new ShopItem
            {
                Name = item.Name,
                Price = item.Price,
                Quantity = quantity,
            });
        }
    }
}
