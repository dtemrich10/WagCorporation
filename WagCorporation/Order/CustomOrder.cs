using Gadgets;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class CustomOrder : IOrder
    {
        public bool isRetailOrder { get; set; }

        public CustomOrder(bool bRetailOrder)
        {
            isRetailOrder = bRetailOrder;
        }
        public void Build()
        {
            ArrayList Gadgets = new ArrayList();
            Gadget gadget = null;
            float FTotalOrderPrice = 0.0f;

            do
            {

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
                    Gadgets.Add(gadget);
                }

                Console.Write("Would you like to order another Gadget Y)es/N)o > ");
                string sResponse = Console.ReadLine();

                if(sResponse.Equals("Y") == false && sResponse.Equals("y") == false)
                {
                    break;
                }
            }
            while (true);

            Console.WriteLine();
            Console.WriteLine("Order Summary for order containing " + Gadgets.Count.ToString() + " Gadget(s)" );

            foreach(IGadget g in Gadgets)
            {
                if (g.GetType() == typeof(SmallGadgets))
                {
                    Console.WriteLine("This is a Small Gadget for " + ((Gadget)g).Price.ToString("C2"));
                }
                else if (g.GetType() == typeof(MediumGadgets))
                {
                    Console.WriteLine("This is a Medium Gadget for " + ((Gadget)g).Price.ToString("C2"));
                }
                else if (g.GetType() == typeof(LargeGadgets))
                {
                    Console.WriteLine("This is a Large Gadget for " + ((Gadget)g).Price.ToString("C2"));
                }

                ((Gadget)g).GetGadgetOrderSummary();
                Console.WriteLine("Subtotal Gadget Price > " + ((Gadget)g).GetGadgetOrderTotalPrice().ToString("C2"));
                FTotalOrderPrice += ((Gadget)g).GetGadgetOrderTotalPrice();
            }

            Console.WriteLine("Shipping cost $25.00");
            FTotalOrderPrice += 25.00f;
            Console.WriteLine("Grand Total Order Price > " + FTotalOrderPrice.ToString("C2"));

        }


    }
}
