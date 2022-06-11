using System;

namespace ShopManagementApp.Models;

public class Item
{
    public int ID { get; set; }
    public string Name { get; set; }
    public DateTime ExpiryDate { get; set; }
    public Shop Shop { get; set; }
    public int? ShopId { get; set; }
}