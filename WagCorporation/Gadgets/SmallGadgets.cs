using Accessories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WagCorporation;

namespace Gadgets
{
    public class SmallGadgets : Gadget, IGadget
    {
        public SmallGadgets() : base(500.00f,  Powered.Power.battery )
        {
           _defaultButtons = 2;
           _defaultSwitches = 1;
           _defaultLights = 0;

            Console.WriteLine("You have selected a Small Gadget for " + Price.ToString("C2"));
        }

        public override void SetupWidgets()
        {
            Console.WriteLine("A Small Gadget comes with 1 Small Widget & 1 Med Widget.");
            AddSmallWidgets(1);
            AddMediumWidgets(1);
        }

        public override void SetupLights()
        {
            Console.WriteLine("No Lights are available for a Small Gadget");
            Lights = _defaultLights;
        }

        public override void SetupSwitches()
        {
            Console.WriteLine("There is " + _defaultSwitches.ToString() + " Switch available for a Small Gadget for " + SwitchPrice + " each.");
            Switches = _defaultSwitches;
        }

        public override void SetupButtons()
        {
            Console.WriteLine("There are " + _defaultButtons.ToString() + " Buttons available for a Small Gadget for " + ButtonPrice + " each.");
            Buttons = _defaultButtons;
        }

        public override void SetupPower()
        {
            SetPower(Powered.Power.battery);
            Console.WriteLine("A Small Gadget comes with a Battery for " + GetGadgetPowerPrice() + " which is included in Gadget price");
        }
    }
}
