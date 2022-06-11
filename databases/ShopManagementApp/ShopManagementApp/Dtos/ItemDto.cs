using ShopManagementApp.Models;
using System.Collections.Generic;

namespace ShopManagementApp.Dtos
{
    public class ItemDto
    {
        public Item Item { get; set; }

        public List<Shop> Shops { get; set; }
    }
}