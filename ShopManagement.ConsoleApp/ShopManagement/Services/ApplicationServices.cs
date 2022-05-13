using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Services
{
    public class ApplicationServices
    {
        private ShopService _shopService;
        public ApplicationServices()
        {
            _shopService = new ShopService();
        }
        public void Process(string command)
        {
            if (command.StartsWith("Add"))
            {
                string[] splitCommand = command.Split(' ');
                _shopService.Add(splitCommand[1], int.Parse(splitCommand[2]));
            }
            else if (command.StartsWith("Remove"))
            {
                string[] splitCommand = command.Split(' ');
                _shopService.Remove(splitCommand[1]);
            }
            else if (command.StartsWith("ListAll"))
            {
                _shopService.ListAll();
            }
            else if (command.StartsWith("End"))
            {
                _shopService.End();
            }
        }
    }
}
