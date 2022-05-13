﻿using ShopManagement.Services;
using System;

namespace ShopManagement
{
    //Lets Create an application for Shop.
    //Shop management system should allow the following commands:
    //"Add <ShopItemName> <quantity>" -> Should add the following item
    //"Remove <ShopItemName>" -> Should remove the following item.
    //"Show" -> Should Display the following items. (name and quantities)
    //"Set <ShopItemName> <quantity>" -> should update the quantity of the item

    //The program should keep in a While loop.

    //Additional Requirements:
    //0. Post this code to github.
    //1. The shop should only allow to add unique names.
    //2. Implement Proper Exit command
    //3. Make application non-crashable.What happens if I type "Add "
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationService applicationService = new ApplicationService();
            while (true)
            {
                        Console.WriteLine("Enter your command:");
                string command = Console.ReadLine();
                applicationService.Process(command);
            }
        }
    }
}
