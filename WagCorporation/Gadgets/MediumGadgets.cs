using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadgets
{
    public class MediumGadgets : Gadget, IGadget
    {
        public MediumGadgets()
        {
            Console.WriteLine("You have selected a Medium Gadget");
        }

        public override void SetupWidgets()
        {
            Console.WriteLine("A Mediam Gadget comes with 2 Small Widgets, 2 Medium Widgets and 1 Large Widget.");
        }

        public override void SetupLights()
        {
            String sLights;

            Console.Write("A few Lights are available for a Medium Gadget, how many do want? > ");
            sLights = Console.ReadLine();
            Lights = int.Parse(sLights);
        }

        public override void SetupSwitches()
        {
            Console.WriteLine("One Switch is added for a Medium Gadget");
            Switches = 1;
        }

        public override void SetupButtons()
        {
            String sButtons;

            Console.Write("Mulitiple Buttons are available for a Mediaum Gadget, how may do you want? > ");
            sButtons = Console.ReadLine();
            Buttons = int.Parse(sButtons);
        }
    }
}
