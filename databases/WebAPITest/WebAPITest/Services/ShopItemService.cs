using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPITest.Models;

namespace WebAPITest.Services
{
    public class ShopItemService
    {
        private List<ShopItem> _shopItems = new List<ShopItem>()
        {
            new ShopItem()
            {
                Name = "Ice Cream",
                ID = 1
            },
            new ShopItem()
            {
                Name = "Candy",
                ID = 2
            }
        };

        public ShopItem Get(int id)
        {
            return _shopItems.First(s => s.ID == id);
        }

        public List<ShopItem> GetAll()
        {
            return _shopItems;
        }

        public void Add(ShopItem shopItem)
        {
            _shopItems.Add(shopItem);
        }

        public void Update(ShopItem shopItem)
        {
            var shopItemToUpdate = _shopItems.First(s => s.ID == shopItem.ID);

            shopItemToUpdate.Name = shopItem.Name;
        }

        public void Remove(int id)
        {
            var shopItemToRemove = _shopItems.First(s => s.ID == id);

            _shopItems.Remove(shopItemToRemove);
        }

    }
}
