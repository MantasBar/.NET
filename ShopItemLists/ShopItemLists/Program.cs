// See https://aka.ms/new-console-template for more information
using ShopItemLists.Services;

ApplicationService applicationServices= new ApplicationService();
while (true)
{
    Console.WriteLine("Enter your command (Add / Remove / Show / Set / Balance / Topup / Buy / Cart)");
    string command = Console.ReadLine();
    applicationServices.Process(command);
    Console.WriteLine();
}