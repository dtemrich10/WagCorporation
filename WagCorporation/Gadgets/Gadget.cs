using Accessories;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Widgets;

namespace Gadgets
{
    public class Gadget : IGadget
    {
        private ArrayList _Widgets = new ArrayList();
        private Switch _Switches;
        private Buttons _Buttons;
        private Lights _Lights;
        private float _Price;


        private int _iTotalGears = 0;
        private int _iTotalSprings = 0;
        private int _iTotalLevers = 0;
        private float _fTotalWidgetPrice = 0.0f;
        private float _fTotalWGadgetPrice = 0.0f;

        public Gadget( float price )
        {
            _Price = price;
            _Switches = new Switch();
            _Buttons = new Buttons();
            _Lights = new Lights();
        }

        public float Price
        {
            get { return _Price; }
        }

        protected int Switches
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
        protected int Buttons
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
        protected int Lights
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

        public void GetGadgetOrderSummary()
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
            Console.WriteLine("Subtotal Widget price " + _fTotalWidgetPrice.ToString("C2"));
        }

        public float GetGadgetOrderTotalPrice()
        {
            return _fTotalWGadgetPrice + _fTotalWidgetPrice;
        }
    }
}
