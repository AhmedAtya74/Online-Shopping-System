using RGB.Models;
using RGB.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingSystem
{
    
    class Demo
    {
        static void Main(string[] args)
        {

            Seller seller = new Seller();
            UI userInterface = new UI();
            userInterface.navbar();

            while (true)
            {
                userInterface.homePage();
                int ithOperation = Convert.ToInt32(Console.ReadLine());
                if (ithOperation == 1)
                {
                    Console.WriteLine("Enter Your Name and Email: ");
                    string name = Console.ReadLine();
                    string email = Console.ReadLine();

                    seller.setName(name);
                    seller.setEmail(email);
                }
                else if (ithOperation == 2)
                {
                    seller.print();
                }
                else if (ithOperation == 3)
                {
                    Item item = new Item();
                    Console.WriteLine("Enter Item's Name, Quantity, Price: ");
                    string name = Console.ReadLine();
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    double price = Convert.ToDouble(Console.ReadLine());
                    item.setName(name);
                    item.setQuantity(quantity);
                    item.setPrice(price);
                    seller.addItem(item);
                }
                else if (ithOperation == 4)
                {
                    Console.WriteLine("Enter Item's Name, Quantity: ");
                    string name = Console.ReadLine();
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    if (seller.sellItem(name, quantity) == true)
                        Console.WriteLine("Transaction Done Successfully");
                    else
                        Console.WriteLine("Transaction Done Unsuccessfully");
                }
                else if (ithOperation == 5)
                {
                    seller.print();
                }
                else if (ithOperation == 6)
                {
                    Console.WriteLine("Enter Item's ID: ");
                    int ID = Convert.ToInt32(Console.ReadLine());
                    if (seller.findByID(ID) == null)
                    {
                        Console.WriteLine("Item not available");
                    }
                    else
                    {
                        seller.findByID(ID).print();
                    }
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }
    }

}
