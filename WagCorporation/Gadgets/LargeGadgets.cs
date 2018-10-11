using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadgets
{
    public class LargeGadgets : Gadget, IGadget
    {

        public LargeGadgets()
        {
            Console.WriteLine("You have selected a Large Gadget");
        }

        public override void SetupWidgets()
        {
            Console.WriteLine("A Large Gadget comes with 3 Small Widgets, 6 Medium Widgets and 3 Large Widgets.");
            AddSmallWidgets(3);
            AddMediumWidgets(6);
            AddLargeWidgets(3);
        }

        public override void SetupLights()
        {
            String sLights;

            Console.WriteLine("Lights are available for a Large Gadget, how many do want? > ");
            sLights = Console.ReadLine();
            Lights = int.Parse(sLights);
        }

        public override void SetupSwitches()
        {
            String sSwitches;

            Console.Write("Switches are available for a Large Gadget, how many do you want? > ");
            sSwitches = Console.ReadLine();
            Switches = int.Parse(sSwitches);
        }

        public override void SetupButtons()
        {
            String sButtons;

            Console.Write("Buttons are available for a Large Gadget, how may do you want? > ");
            sButtons = Console.ReadLine();
            Buttons = int.Parse(sButtons);
        }
    }
}
