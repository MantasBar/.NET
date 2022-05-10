using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement.ConsoleApp.Services
{
    public class ApplicationService
    {
        private WarehouseService _warehouseService;
        public ApplicationService()
        {
            _warehouseService = new WarehouseService();
        }
        public void Process(string command)
        {
            if (command.StartsWith("Add"))
            {
                _warehouseService.Add();
            }
            if (command.StartsWith("Remove"))
            {
                _warehouseService.Remove();
            }
            if (command.StartsWith("List"))
            {
                
            }
            if (command.StartsWith("Exit"))
            {
                return;
            }
            Console.WriteLine("Incorrect command");
            // Interpret if command is valid
            // Parse the command type and information
            // Call appropriate WarehouseService command
        }
    }
}
