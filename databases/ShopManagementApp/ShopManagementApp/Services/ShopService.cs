using ShopManagementApp.Data;
using ShopManagementApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShopManagementApp.Services;

public class ShopService
{
    private DataContext _dataContext;

    public ShopService(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public List<Shop> GetAll()
    {
        return _dataContext.Shops.ToList();
    }

    public void Add(Shop shop)
    {
        _dataContext.Shops.Add(shop);
        _dataContext.SaveChanges();
    }
    public void Delete(string name)
    {
        var shop = _dataContext.Shops.FirstOrDefault(x => x.Name == name);
        _dataContext.Shops.Remove(shop);
        _dataContext.SaveChanges();
    }
}

