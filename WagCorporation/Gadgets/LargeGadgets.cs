using Accessories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadgets
{
    public class LargeGadgets : Gadget, IGadget
    {
        private string _sDefaultLargePower;

        public LargeGadgets( string sDefaultPower ) : base(800.00f, Powered.Power.solar)
        {
            _sDefaultLargePower = sDefaultPower;
            _defaultButtons = 2;
            _defaultSwitches = 1;
            _defaultLights = 3;
            Console.WriteLine("You have selected a Large Gadget  for " + Price.ToString("C2"));
        }

        public LargeGadgets() : base(800.00f, Powered.Power.solar)
        {
          _defaultButtons = 2;
          _defaultSwitches = 1;
          _defaultLights = 3;
           Console.WriteLine("You have selected a Large Gadget  for " + Price.ToString("C2"));
        }

        public override void SetupWidgets()
        {
            if (!isRetailOrder)
            {
                Console.WriteLine("A Large Gadget comes with 3 Small Widgets, 6 Medium Widgets and 3 Large Widgets.");
            }

            AddSmallWidgets(3);
            AddMediumWidgets(6);
            AddLargeWidgets(3);
        }

        public override void SetupLights()
        {
            String sLights;
            if (!isRetailOrder)
            {

                Console.WriteLine("There are " + _defaultLights.ToString() + " Lights available for a Large Gadget for " + LightPrice + " each.");
                Console.Write("However more Lights can be added for a surcharge of " + LightPrice + " each, how may would you like? > ");
                sLights = Console.ReadLine();
                Lights = int.Parse(sLights) + _defaultLights;
            }
            else
            {
                Lights = _defaultLights;
            }
        }

        public override void SetupSwitches()
        {
            String sSwitches;

            if (!isRetailOrder)
            {
                Console.WriteLine("There is " + _defaultSwitches.ToString() + " Switches available for a Large Gadget for " + SwitchPrice + " each.");
                Console.Write("However more Switches can be added for a surcharge of " + SwitchPrice + " each, how may would you like? > ");
                sSwitches = Console.ReadLine();
                Switches = int.Parse(sSwitches) + _defaultSwitches;
            }
            else
            {
                Switches = _defaultSwitches; 
            }
        }

        public override void SetupButtons()
        {
            String sButtons;

            if (!isRetailOrder)
            {
                Console.WriteLine("There are " + _defaultButtons.ToString() + " Buttons available for a Large Gadget. for " + ButtonPrice + " each.");
                Console.Write("However more Buttons can be added for a surcharge of " + ButtonPrice + " each, how may would you like? > ");
                sButtons = Console.ReadLine();
                Buttons = int.Parse(sButtons) + _defaultButtons;
            }
            else
            {
                Buttons = _defaultButtons;
            }

        }

        public override void SetupPower()
        {
            string sPower;
            if (!isRetailOrder)
            {

                float fDifference = GetLargePowerDifference();
                Console.WriteLine("A Large Gadget comes with a Solar or Generator for " + fDifference.ToString("C2") + " more.");
                Console.Write("Which would you like a S)olar or G)enerator ? > ");
                sPower = Console.ReadLine();
            }
            else
            {
                sPower = _sDefaultLargePower;
            }

            if (sPower.Equals("G") || sPower.Equals("g"))
            {
                SetPower(Powered.Power.generator);
            }
            else
            {
                SetPower(Powered.Power.solar);
            }
        }

        public static float GetLargePowerDifference()
        {
            float fDifference = GetGadgetPowerPrice((int)Powered.Power.generator) - GetGadgetPowerPrice((int)Powered.Power.solar);
            return fDifference;
        }
    }
}
