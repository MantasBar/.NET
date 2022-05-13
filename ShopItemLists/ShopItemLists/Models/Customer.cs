using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopItemLists.Models
{
    public class Customer
    {
        public decimal Money { get; set; }
        public List<ShopItem> Basket { get; set; }
    }
}
