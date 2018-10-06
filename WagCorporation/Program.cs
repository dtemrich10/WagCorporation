using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gadgets;

namespace WagCorporation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Gadget gadget = null;
            Console.WriteLine("Welcome to the Wag Corporation's Gadget ordering application");
            Console.Write("Enter The Gadget size you wish S)mall, M)edium, L)arge > ");
            String sGadgetOrder = Console.ReadLine();

            switch (sGadgetOrder)
            {
                case "S":
                case "s":
                    gadget = new SmallGadgets();
                break;

                case "M":
                case "m":
                    gadget = new MediumGadgets();
                break;

                case "L":
                case "l":
                    gadget = new LargeGadgets();
                break;

                default:
                    Console.WriteLine("Try again");
                break;
            }

            if (gadget != null)
            {
                gadget.SetupWidgets();
                gadget.SetupSwitches();
                gadget.SetupButtons();
                gadget.SetupLights();
            }
        }
    }
}
