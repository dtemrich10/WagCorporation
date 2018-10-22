using Gadgets;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class RetailOrder : IOrder
    {
        ArrayList _Gadgets = new ArrayList();

        public bool isRetailOrder { get; set; }

        public RetailOrder( bool bRetailOrder )
        {
            isRetailOrder = bRetailOrder;
        }

        public void Build()
        {
            string sResponse;
            int iNum;

            Console.WriteLine("Welcone to express ordering.");
            Console.Write("How many Small Gadgets would you like? > ");
            sResponse = Console.ReadLine();
            iNum = int.Parse(sResponse);

            Console.Write("How many Medium Gadgets would you like? > ");
            sResponse = Console.ReadLine();
            iNum = int.Parse(sResponse);

            Console.Write("How many Large Gadgets would you like? > ");
            sResponse = Console.ReadLine();
            iNum = int.Parse(sResponse);
        }

        private void setupSmallGadgets( int iNum )
        {
            Gadget gadget = null;
            for (int ii=0; ii < iNum; ii++)
            {
                gadget = new SmallGadgets();
                setupGadget(gadget);
            }

        }

        private void setupMediumGadgets( int iNum )
        {
            Gadget gadget = null;
            for (int ii = 0; ii < iNum; ii++)
            {
                gadget = new MediumGadgets();
                setupGadget(gadget);
            }

        }

        private void setupLargeGadgets( int iNum )
        {
            Gadget gadget = null;
            for (int ii = 0; ii < iNum; ii++)
            {
                gadget = new LargeGadgets();
                setupGadget(gadget);
            }

        }

        private void setupGadget(Gadget gadget)
        {
            gadget.SetupPainted();
            gadget.SetupWidgets();
            gadget.SetupSwitches();
            gadget.SetupButtons();
            gadget.SetupLights();
            gadget.SetupPower();
            _Gadgets.Add(gadget);
        }

    }
}
