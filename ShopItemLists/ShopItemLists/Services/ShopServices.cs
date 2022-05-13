using ShopItemLists.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopItemLists.Services
{
    public class ShopServices
    {
        List<string> _cart = new List<string>();
        decimal Balance = 20;

        List <ShopItem> _items = new List<ShopItem>();
        public ShopServices()
        {
            _items = new List<ShopItem>();
        }
        public void Add(string name, decimal price, int quantity)
        {
            ShopItem item = new ShopItem()
            {
                Name = name,
                Price = price,
                Quantity = quantity
            };
            _items.Add(item);
            Console.WriteLine(name + " added to the shop item list");
        }
        public void Remove(string name)
        {
            if(_items.Any(i => i.Name == name))
            {
                _items.RemoveAll(i => i.Name != name);
            }
            else
            {
                Console.WriteLine($"{name} not found in the shop item list");
            }
        }
        public void Show()
        {
            _items.ForEach(i => Console.WriteLine($"Name: {i.Name}  Quantity: {i.Quantity}  Price: {i.Price}"));
        }
        public void Set(string name, int quantity)
        {
            ShopItem item = _items.Single(i => i.Name == name);
            item.Quantity = quantity;
        }
        public void ShowBalance()
        {
            Console.WriteLine("Balance: " + Balance);
        }
        public void Topup(decimal top)
        {
            Balance += top;
            Console.WriteLine($"Topped up balance: {Balance}");
        }
        public void Buy(string name, int quantity)
        {
            if(_items.Any(i => i.Name == name))
            {
                if(_items.Any(i => i.Quantity >= quantity) && quantity > 0)
                {
                    if(_items.Any(i => (i.Price * quantity) <= Balance))
                    {
                        _cart.Add(name);
                        decimal price = _items.Find(i => i.Name == name).Price;
                        Balance -= (price * quantity);
                        ShopItem item = _items.FirstOrDefault(i => i.Name == name);
                        item.Quantity -= quantity;
                    }
                    else
                    {
                        Console.WriteLine("Customer does not have enough funds");
                    }
                }
                else
                {
                    Console.WriteLine("Shop does not have enough quantity");
                }
            }
            else
            {
                Console.WriteLine("Shop item is not found");
            }
        }
        public void ShowCart()
        {
            _cart.ForEach(i => Console.WriteLine($"Name: {i}"));
        }
    }
}
