using System;

namespace ShopManagementApp.Models
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ShopName { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
