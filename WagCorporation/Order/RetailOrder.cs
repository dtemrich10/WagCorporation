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
        private ArrayList _Gadgets = new ArrayList();
        private int _iNumberOfSmallGadgets = 0;
        private int _iNumberOfMediumGadgets = 0;
        private int _iNumberOfLargeGadgets = 0;

        private string _sColorDefaultGadget;
        private string _sColorDefaultWidget;
        private string _sDefaultPower;

        public bool isRetailOrder { get; set; }

        public RetailOrder( bool bRetailOrder )
        {
            isRetailOrder = bRetailOrder;
        }

        public void Build()
        {
            try
            {

                string sResponse;

                Console.WriteLine("Welcome to express ordering.");
                Console.Write("What color would you like the Gagdets to be (Blue, Gold, Green, Orange, Red, Purple) ? > ");
                _sColorDefaultGadget = Console.ReadLine();
                Console.Write("What color would you like the Widgets to be (Blue, Gold, Green, Orange, Red, Purple) ? > ");
                _sColorDefaultWidget = Console.ReadLine();


                Console.Write("How many Small Gadgets would you like? > ");
                sResponse = Console.ReadLine();
                _iNumberOfSmallGadgets = int.Parse(sResponse);
                if (_iNumberOfSmallGadgets > 0 )
                {
                    SetupSmallGadgets();
                }

                Console.Write("How many Medium Gadgets would you like? > ");
                sResponse = Console.ReadLine();
                _iNumberOfMediumGadgets = int.Parse(sResponse);
                if (_iNumberOfMediumGadgets > 0 )
                {
                    float fDifference = MediumGadgets.GetMediumPowerDifference();
                    Console.WriteLine("A Medium Gadget comes with a Battery or Solar for " + fDifference.ToString("C2") + " more.");
                    Console.Write("What would you like for the medium power default B)attery or S)olar ? > ");
                    _sDefaultPower = Console.ReadLine();
                    SetupMediumGadgets();
                }

                Console.Write("How many Large Gadgets would you like? > ");
                sResponse = Console.ReadLine();
                _iNumberOfLargeGadgets = int.Parse(sResponse);
                if (_iNumberOfLargeGadgets > 0)
                {
                    float fDifference = LargeGadgets.GetLargePowerDifference();
                    Console.WriteLine("A Large Gadget comes with a Solar or Generator for " + fDifference.ToString("C2") + " more.");
                    Console.Write("What would you like for the large power default S)olar or G)enerator ? > ");
                    _sDefaultPower = Console.ReadLine();
                    SetupLargeGadgets();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error has occurred " + e.Message);
                return;
            }

            GetOrderSummary();
        }

        private void SetupSmallGadgets()
        {
            Gadget gadget = null;
            for (int ii=0; ii < _iNumberOfSmallGadgets; ii++)
            {
                gadget = new SmallGadgets();
                SetupGadget(gadget);
            }

        }

        private void SetupMediumGadgets()
        {
            Gadget gadget = null;
            for (int ii = 0; ii < _iNumberOfMediumGadgets; ii++)
            {
                gadget = new MediumGadgets(_sDefaultPower);
                SetupGadget(gadget);
            }

        }

        private void SetupLargeGadgets()
        {
            Gadget gadget = null;
            for (int ii = 0; ii < _iNumberOfLargeGadgets; ii++)
            {
                gadget = new LargeGadgets(_sDefaultPower);
                SetupGadget(gadget);
            }

        }

        private void SetupGadget(Gadget gadget)
        {
            gadget.isRetailOrder = true;
            gadget.SetupPaintedDefault( _sColorDefaultGadget );
            gadget.sDefaultWidgetColor = _sColorDefaultWidget;
            gadget.SetupWidgets();
            gadget.SetupSwitches();
            gadget.SetupButtons();
            gadget.SetupLights();
            gadget.SetupPower();
            _Gadgets.Add(gadget);
        }

        private void GetOrderSummary()
        {
            int iWidGears = 0;
            int iWidSprings = 0;
            int iWidLevers = 0;
            int iWidgets = 0;

            int iTotalWidGears = 0;
            int iTotalWidSprings = 0;
            int iTotalWidLevers = 0;
            int iTotalWidgets = 0;

            int iTotalButtons = 0;
            int iTotalLights = 0;
            int iTotalSwitches = 0;

            float fTotalOrderPrice = 0.0f;

            Console.WriteLine();

            foreach (Gadget g in _Gadgets)
            {
                ((Gadget)g).GetWidgetOrderSummary(out iWidgets, out iWidGears, out iWidSprings, out iWidLevers);
                iTotalWidGears += iWidGears;
                iTotalWidSprings += iWidSprings;
                iTotalWidLevers += iWidLevers;
                iTotalWidgets += iWidgets;

                iTotalButtons += ((Gadget)g).Buttons;
                iTotalLights += ((Gadget)g).Lights;
                iTotalSwitches += ((Gadget)g).Switches;

                fTotalOrderPrice += ((Gadget)g).GetGadgetOrderTotalPrice();

            }

            Console.WriteLine("******Order Summary*****");

            Console.WriteLine("Total Gadgets  > {0, 5} {1, 5}", (_iNumberOfSmallGadgets + _iNumberOfMediumGadgets + _iNumberOfLargeGadgets).ToString(), " that are painted " +  _sColorDefaultGadget);

            Console.WriteLine("Total Butttons > {0, 5}", iTotalButtons.ToString());
            Console.WriteLine("Total Lights   > {0, 5}", iTotalLights.ToString());
            Console.WriteLine("Total Switches > {0, 5}", iTotalSwitches.ToString());

            Console.WriteLine("Total Widgets  > {0, 5} {1, 5}", iTotalWidgets.ToString(), " that are painted " + _sColorDefaultWidget);
            Console.WriteLine("Total Gears    > {0, 5}", iTotalWidGears.ToString());
            Console.WriteLine("Total Springs  > {0, 5}", iTotalWidSprings.ToString());
            Console.WriteLine("Total Levers   > {0, 5}", iTotalWidLevers.ToString());

            Console.WriteLine("Sub Total Price         > {0, 20}", fTotalOrderPrice.ToString("C2"));
            Console.WriteLine("Shipping Cost           > {0, 20}", "$25.00");
            fTotalOrderPrice += 25.00f;
            Console.WriteLine("Grand Total Order Price > {0, 20}", fTotalOrderPrice.ToString("C2"));
        }

    }
}
