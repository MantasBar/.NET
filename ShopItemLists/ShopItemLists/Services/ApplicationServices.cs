using ShopItemLists.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopItemLists.Services
{
    public class ApplicationServices
    {
        private ShopServices _services;
        public ApplicationServices()
        {
            _services = new ShopServices();
        }
        public void Process(string command)
        {
            command = command.ToLower();
            if (command.ToLower().StartsWith("add"))
            {
                try
                {
                    string[] splitCommand = command.Split(' ');
                    if (decimal.Parse(splitCommand[2]) > 0 && int.Parse(splitCommand[3]) > 0)
                    {
                        _services.Add(splitCommand[1], decimal.Parse(splitCommand[2]), int.Parse(splitCommand[3]));
                    }
                    else
                    {
                        Console.WriteLine("Price and quantity have to be greater than 0");
                    }
                }
                catch
                {
                    Console.WriteLine("The command was not recognized");
                    Console.WriteLine("Example: Add itemName itemPrice itemQuantity");
                }
            }

            else if (command.ToLower().StartsWith("remove"))
            {
                try
                {
                    string[] splitCommand = command.Split(' ');
                    _services.Remove(splitCommand[1]);
                }
                catch
                {
                    Console.WriteLine("The command was not recognized");
                    Console.WriteLine("Example: remove itemName");
                }
            }

            else if (command.ToLower().StartsWith("show"))
            {
                _services.Show();
            }

            else if(command.ToLower().StartsWith("set"))
            {
                string[] splitCommand = command.Split(' ');
                _services.Set(splitCommand[1], int.Parse(splitCommand[3]));
            }

            else if (command.ToLower().StartsWith("balance"))
            {
                _services.ShowBalance();
            }

            else if (command.ToLower().StartsWith("topup"))
            {
                string[] splitCommand = command.Split(' ');
                _services.Topup(decimal.Parse(splitCommand[1]));
            }

            else if (command.ToLower().StartsWith("buy"))
            {
                string[] splitCommand = command.Split(' ');
                _services.Buy(splitCommand[1], int.Parse(splitCommand[2]));
            }

            else if (command.ToLower().StartsWith("cart"))
            {
                _services.ShowCart();
            }
            else if (command.ToLower().StartsWith("exit"))
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("The command was not recognized");
            }
        }
    }
}
