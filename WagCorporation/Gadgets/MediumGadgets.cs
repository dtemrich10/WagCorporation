using Accessories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadgets
{
    public class MediumGadgets : Gadget, IGadget
    {

        public MediumGadgets() : base (600.00f, Powered.Power.battery)
        {
            _defaultButtons = 2;
            _defaultSwitches = 1;
            _defaultLights = 3;
            Console.WriteLine("You have selected a Medium Gadget for " + Price.ToString("C2"));
        }

        public override void SetupWidgets()
        {
            Console.WriteLine("A Mediam Gadget comes with 2 Small Widgets, 2 Medium Widgets and 1 Large Widget." );
            AddSmallWidgets(2);
            AddMediumWidgets(2);
            AddLargeWidgets(1);
        }

        public override void SetupLights()
        {
            //           String sLights;

            Console.Write("There are " + _defaultLights.ToString() + " Lights available for a Medium Gadget for " + LightPrice + " each.");
            //            sLights = Console.ReadLine();
            //            Lights = int.Parse(sLights);
            Lights = _defaultLights;
        }

        public override void SetupSwitches()
        {
            Console.WriteLine("There is " + _defaultSwitches.ToString() + " Switches available for a Medium Gadget for " + SwitchPrice + " each.");
            Switches = _defaultSwitches;
        }

        public override void SetupButtons()
        {
            String sButtons;

            Console.WriteLine("There are " + _defaultButtons.ToString() + " Buttons available for a Mediaum Gadget for " + ButtonPrice + " each.");
            Console.Write("However more Buttons can be added for a surcharge of " + ButtonPrice +  " each, how may would you like? > ");
            sButtons = Console.ReadLine();
            Buttons = int.Parse(sButtons) + _defaultButtons;
        }

        public override void SetupPower()
        {
            float fDifference = GetGadgetPowerPrice((int)Powered.Power.solar ) - GetGadgetPowerPrice((int)Powered.Power.battery);
            string sPower;

            Console.WriteLine("A Medium Gadget comes with a Battery or Solar for " + fDifference.ToString("C2") + " more.");
            Console.Write("Which would you like a B)attery or S)olar ? > ");
            sPower = Console.ReadLine();

            if (sPower.Equals("Solar") || sPower.Equals("solar"))
            {
                SetPower(Powered.Power.solar);
            }
            else
            {
                SetPower(Powered.Power.battery);
            }
        }
    }
}
