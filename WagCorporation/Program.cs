using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gadgets;
using Order;

namespace WagCorporation
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Wag Corporation's Gadget ordering application");
            Console.Write("Will this be a R)etail or C)ustom order? > ");
            string sOrderType = Console.ReadLine();
            if (sOrderType.Equals("R") == true || sOrderType.Equals("r") == true)
            {
                OrderFactory retailOrder = new RetailOrderFactory();
                retailOrder.Build();
            }
            else
            {
                OrderFactory customOrder = new CustomOrderFactory();
                customOrder.Build();
            }
        }
    }
}
