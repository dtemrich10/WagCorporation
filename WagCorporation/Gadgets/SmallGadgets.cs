using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        public override void SetupLights()
        {
            Console.WriteLine("No Lights are available for a Small Gadget");
            Lights = 0;
        }

        public override void SetupSwitches()
        {
            Console.WriteLine("One Switch is added for a Small Gadget");
            Switches = 1;
        }

        public override void SetupButtons()
        {
            Console.WriteLine("Two Buttons are added for a Small Gadget");
            Buttons = 2;
        }
    }
}
