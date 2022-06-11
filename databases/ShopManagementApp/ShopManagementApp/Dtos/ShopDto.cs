using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagementApp.Dtos
{
    public class ShopDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ItemDto> Items { get; set; }
    }
}
