using ShopItemLists.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopItemLists.Services
{
    public class ApplicationService
    {
        private ShopService _service = new ShopService();
        public ApplicationService()
        {
            _service = new ShopService();
        }
        public void Process(string command)
        {
            try
            {
                command = command.ToLower();
                string[] parameters = command.Split(" ");

                if (command.StartsWith("add"))
                {
                    decimal price = decimal.Parse(parameters[2]);
                    int quantity = int.Parse(parameters[3]);

                    _service.Add(parameters[1], price, quantity);
                }

                else if (command.StartsWith("remove"))
                {
                    _service.Remove(parameters[1]);
                }

                else if (command.StartsWith("show"))
                {
                    List<ShopItem> items = _service.GetAll();
                    items.ForEach(i => Console.WriteLine(i.ToString()));
                }

                else if (command.StartsWith("set"))
                {
                    int quantity = int.Parse(parameters[2]);

                    _service.Set(parameters[1], quantity);
                }

                else if (command.StartsWith("balance"))
                {
                    decimal balance = _service.GetBalance();

                    Console.WriteLine($"Balance: {balance}");
                }

                else if (command.StartsWith("topup"))
                {
                    decimal topup = decimal.Parse(parameters[1]);

                    _service.Topup(topup);
                }

                else if (command.StartsWith("buy"))
                {
                    int quantity = int.Parse(parameters[2]);

                    _service.Buy(parameters[1], quantity);
                }

                else if (command.StartsWith("cart"))
                {
                    List<ShopItem> items = _service.GetCart();
                    items.ForEach(i => Console.WriteLine(i.ToString()));
                }

                else if (command.StartsWith("exit"))
                {
                    Environment.Exit(0);
                }
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Something wrong with your parameters");
            }

            catch (Exception ex)
            {
                Console.WriteLine("something wrong has happened");
            }
        }
    }
}
