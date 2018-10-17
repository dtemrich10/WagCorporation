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
        public SmallGadgets()
        {
            Console.WriteLine("You have selected a Small Gadget");
        }

        public override void SetupWidgets()
        {
            Console.WriteLine("A Small Gadget comes with 1 Small Widget & 1 Med Widget");
            AddSmallWidgets(1);
            AddMediumWidgets(1);
        }

        public override void SetupLights()
        {
            Lights = 0;
            Console.WriteLine("No Lights are available for a Small Gadget");
        }

        public override void SetupSwitches()
        {
            Switches = 1;
            Console.WriteLine("One Switch is added for a Small Gadget for " + SwitchPrice + " each" );
        }

        public override void SetupButtons()
        {
            Buttons = 2;
            Console.WriteLine("Two Buttons are added for a Small Gadget for " + ButtonPrice + " each");
        }
    }
}
