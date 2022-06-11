using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAPITest.Models;
using WebAPITest.Services;

namespace WebAPITest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopItemController : ControllerBase
    {
        private readonly ShopItemService _shopItemService;

        public ShopItemController(ShopItemService shopItemService)
        {
            _shopItemService = shopItemService;
        }

        [HttpGet]
        public List<ShopItem> GetAll()
        {
            return _shopItemService.GetAll();
        }

        [HttpGet("{id}")]
        public ShopItem GetAll(int id)
        {
            return _shopItemService.Get(id);
        }

        [HttpPost]
        public void Create(ShopItem shopItem)
        {
            _shopItemService.Add(shopItem);
        }

        [HttpPut]
        public void Update(ShopItem shopItem)
        {
            _shopItemService.Update(shopItem);
        }

        [HttpDelete("{id}")]
        public void Remove(int id)
        {
            _shopItemService.Remove(id);
        }
    }
}
