using Microsoft.AspNetCore.Mvc;
using ShopManagementApp.Dtos;
using ShopManagementApp.Models;
using ShopManagementApp.Services;

namespace ShopManagementApp.Controllers
{
    public class ItemController : Controller
    {
        private ItemService _itemService;

        public ItemController(ItemService itemService)
        {
            _itemService = itemService;
        }

        public IActionResult Index()
        {
            var items = _itemService.GetAll();
            return View(items);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ItemDto item = new ItemDto();
            return View(item);
        }

        [HttpPost]
        public IActionResult Add(ItemDto createItem)
        {
            _itemService.Add(createItem.Item);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(string name)
        {
            _itemService.Delete(name);
            return RedirectToAction("Index");
        }
    }
}
