using Microsoft.AspNetCore.Mvc;
using ShopManagementApp.Models;
using ShopManagementApp.Services;

namespace ShopManagementApp.Controllers;

public class ShopController : Controller
{
    private ShopService _shopService;

    public ShopController(ShopService shopService)
    {
        _shopService = shopService;
    }
    
    public IActionResult Index()
    {
        var items = _shopService.GetAll();
        return View(items);
    }

    [HttpGet]
    public IActionResult Add()
    {
        Shop shop = new Shop();
        return View(shop);
    }

    [HttpPost]
    public IActionResult Add(Shop shop)
    {
        _shopService.Add(shop);
        return RedirectToAction("Index");
    }

    public IActionResult Delete(string name)
    {
        _shopService.Delete(name);
        return RedirectToAction("Index");
    }
}
