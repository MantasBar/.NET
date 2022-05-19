using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopItemLists.Models
{
    public class Customer
    {
        public decimal Balance { get; set; } = 20;
        public List<ShopItem> Cart { get; set; } = new List<ShopItem> { };
    }
}
