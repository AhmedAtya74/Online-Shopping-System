using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB.Views
{
    class UI
    {
        public void navbar()
        {
            Console.WriteLine("WELCOME Online Shopping System");
        }
        public void homePage()
        {

            Console.WriteLine("Select Number of Operation: ");

            Console.WriteLine("1- Create Account");
            Console.WriteLine("2- Print My Information.");
            Console.WriteLine("3- Add an Item.");
            Console.WriteLine("4- Sell an Item.");
            Console.WriteLine("5- Print Items");
            Console.WriteLine("6- Find an Item By ID");
            Console.WriteLine("7- Exit");
        }
    }
}
