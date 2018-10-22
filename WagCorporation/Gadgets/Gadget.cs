using Accessories;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Widgets;

namespace Gadgets
{
    public abstract class Gadget : IGadget
    {
        private ArrayList _Widgets = new ArrayList();
        private Switch _Switches;
        private Buttons _Buttons;
        private Lights _Lights;
        private float _Price;
        private Painted _painted;
        private Powered _power;


        private int _iTotalGears = 0;
        private int _iTotalSprings = 0;
        private int _iTotalLevers = 0;
        private float _fTotalWidgetPrice = 0.0f;

        protected int _defaultButtons;
        protected int _defaultSwitches;
        protected int _defaultLights;
        protected Powered  _defaultPower;


        public Gadget( float price, Powered.Power power )
        {
            _Price = price;
            _Switches = new Switch();
            _Buttons = new Buttons();
            _Lights = new Lights();
            _painted = new Painted();
            _power = new Powered();
            _power.DefaultPower = power;
        }

        public float Price
        {
            get { return _Price; }
        }

        public int Switches
        {
            get
            {
                return _Switches.Quantity;
            }
            set
            {
                _Switches.Quantity  = value;
            }
        }
        protected string SwitchPrice
        {
            get
            {
                return _Switches.Price.ToString("C2");
            }
        }
        public int Buttons
        {
            get
            {
                return _Buttons.Quantity;
            }
            set
            {
                _Buttons.Quantity = value;
            }
        }
        protected string ButtonPrice
        {
            get
            {
                return _Buttons.Price.ToString("C2");
            }
        }
        public int Lights
        {
            get
            {
                return _Lights.Quantity;
            }
            set
            {
                _Lights.Quantity = value;
            }
        }
        protected string LightPrice
        {
            get
            {
                return _Lights.Price.ToString("C2");
            }
        }

        protected void SetPower(Powered.Power gPower)
        {
            _power.power = gPower;
        }

        public string GetPower()
        {
            switch (_power.power)
            {
                case Powered.Power.solar:
                    return "Solar";
                case Powered.Power.battery:
                    return "Battery";
                default :
                    return "Generator";
            }
        }

        public void AddSmallWidgets(int iNum)
        {
            for(int ii=0; ii < iNum; ii++)
            {
                SmallWidget sw = new SmallWidget();
                AddWidget(sw);
            }
        }

        public void AddMediumWidgets(int iNum)
        {
            for (int ii = 0; ii < iNum; ii++)
            {
                MediumWidget mw = new MediumWidget();
                AddWidget(mw);
            }
        }

        public void AddLargeWidgets(int iNum)
        {
            for (int ii = 0; ii < iNum; ii++)
            {
                LargeWidget lw = new LargeWidget();
                AddWidget(lw);
            }
        }

        private void AddWidget(IWidgets iw)
        {
            _Widgets.Add(iw);
            iw.SetupGears();
            iw.SetupLevers();
            iw.SetupSprings();
            ((Widget)iw).SetupPainted();
        }

        public virtual void SetupWidgets()
        {
        }

        public virtual void SetupLights()
        {
        }

        public virtual void SetupSwitches()
        {
        }

        public virtual void SetupButtons()
        {

        }

        public virtual void SetupPower()
        {

        }

        public string GetGadgetPowerPrice()
        {
            return _power.GetTotalPrice();
        }

        protected float GetGadgetPowerPrice(int option)
        {
            return _power.PowerPrice[option];
        }

        public void SetupPainted()
        {
            String sPainted;

            Console.Write("Choose an option for the Gadget to be painted (Paint, Plated, Plain) ? > ");
            sPainted = Console.ReadLine();
            switch (sPainted)
            {
                case "Plated":
                case "plated":
                    _painted.paint = Painted.Paint.plated;
                    break;
                case "Paint":
                case "paint":
                    String sColor;

                    _painted.paint = Painted.Paint.painted;
                    Console.Write("What color would you like (Blue, Gold, Green, Orange, Red, Purple) ? > ");
                    sColor = Console.ReadLine();
                    switch (sColor)
                    {
                        case "Blue":
                        case "blue":
                            _painted.color = Painted.Colors.Blue;
                            break;
                        case "Green":
                        case "green":
                            _painted.color = Painted.Colors.Green;
                            break;
                        case "Orange":
                        case "orange":
                            _painted.color = Painted.Colors.Orange;
                            break;
                        case "Red":
                        case "red":
                            _painted.color = Painted.Colors.Red;
                            break;
                        case "Purple":
                        case "purple":
                            _painted.color = Painted.Colors.Purple;
                            break;
                        default:
                            _painted.color = Painted.Colors.Gold;
                            break;
                    }
                    break;
                default:
                    _painted.paint = Painted.Paint.plain;
                    break;
            }
        }

        public void GetPainted()
        {

            if (_painted.paint.Equals(Painted.Paint.painted) == true)
            {
                Console.WriteLine(" Gadget is " + _painted.paint.ToString() + " " + _painted.color.ToString());
            }
            else if (_painted.paint.Equals(Painted.Paint.plated) == true)
            {
                Console.WriteLine(" Gadget is " + _painted.paint.ToString() + " and has a surcharge of " + _painted.GetTotalPrice().ToString("C2"));
            }
            else
            {
                Console.WriteLine(" Gadget is " + _painted.paint.ToString());
            }

        }

        public void GetWidgetOrderSummary()
        {

            Console.WriteLine("This order has a total of  " + _Widgets.Count.ToString()  + " Widgets");

            foreach (IWidgets wi in _Widgets)
            {
                ((Widget)wi).getWidgetOrderSummary();
                ((Widget)wi).getPainted();
                _fTotalWidgetPrice += ((Widget)wi).getWidgetPrice();
                _iTotalGears += ((Widget)wi).Gears ;
                _iTotalSprings += ((Widget)wi).Springs;
                _iTotalLevers += ((Widget)wi).Levers;
            }
            Console.WriteLine("This order comes with " + _iTotalGears.ToString()  + " Gears");
            Console.WriteLine("This order comes with " + _iTotalLevers.ToString() + " Levers");
            Console.WriteLine("This order comes with " + _iTotalSprings.ToString() + " Springs");
            Console.WriteLine("Subtotal Widget Price > " + _fTotalWidgetPrice.ToString("C2"));
        }

        public float GetGadgetOrderTotalPrice()
        {
            float fTotalWGadgetPrice = Price + _power.GetTotalPriceMoney() + _painted.GetTotalPrice();
            Console.WriteLine("Subtotal Gadget Price > " + fTotalWGadgetPrice.ToString("C2"));

            return fTotalWGadgetPrice +  + _fTotalWidgetPrice;
        }
    }
}
