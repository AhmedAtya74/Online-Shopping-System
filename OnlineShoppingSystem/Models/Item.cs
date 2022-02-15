using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB.Models
{
    class Item
    {
        private int ID;
        private string name;
        private int quantity;
        private double price;
        private static int RandomIDs = 1;

        private int generateID()
        {
            return RandomIDs++;
        }


        // Defualt Constructor
        public Item()
        {
            ID = generateID();
            name = "";
            quantity = 0;
            price = 0;
        }


        // Para Constructor
        public Item(string name, int quantity, double price)
        {
            this.ID = generateID();
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }

        // Copy Constructor
        public Item(Item item)
        {
            this.ID = item.ID;
            this.name = item.name;
            this.quantity = item.quantity;
            this.price = item.price;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public int getID()
        {
            return this.ID;
        }
        public string getName()
        {
            return this.name;
        }

        public int getQuantity()
        {
            return this.quantity;
        }

        public double getPrice()
        {
            return this.price;
        }

        public void print()
        {
            Console.WriteLine("Item ID: " + this.ID + " ,Name: " + this.name + " ,Quantity: " + this.quantity + " ,Price: " + this.price);
        }
    }
}
