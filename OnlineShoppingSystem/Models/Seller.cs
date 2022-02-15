using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB.Models
{
    class Seller
    {
        private string name;
        private string email;
        LinkedList<Item> items;


        public Seller()
        {
            name = "";
            email = "";
            items = new LinkedList<Item>();
        }


        public Seller(string name, string email, Item item)
        {
            this.name = name;
            this.email = email;
            items.AddLast(item);
        }


        public void setName(string name)
        {
            this.name = name;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        // Name is a key
        private Item findByName(string name)
        {
            foreach (Item element in items)
            {
                if (name == element.getName())
                {
                    return element;
                }
            }
            return null;
        }



        public void addItem(Item item)
        {
            Item similarItem = findByName(item.getName());
            if (similarItem != null)
                similarItem.setQuantity(similarItem.getQuantity() + 1);
            else
                items.AddLast(item);
        }

        private bool enoughQuantity(Item item, int quantity)
        {
            return item.getQuantity() >= quantity;
        }


        public bool sellItem(string name, int quantity)
        {
            Item targetItem = findByName(name);
            if (targetItem != null && enoughQuantity(targetItem, quantity))
            {
                targetItem.setQuantity(targetItem.getQuantity() - quantity);
                return true;
            }
            else
                return false;

        }

        public Item findByID(int ID)
        {
            foreach (Item element in items)
            {
                if (ID == element.getID())
                {
                    return element;
                }
            }
            return null;
        }

        public void print()
        {
            Console.WriteLine("Seller Name: " + this.name + " ,Email: " + this.email);

            foreach (Item item in items)
                item.print();
        }

    }
}
