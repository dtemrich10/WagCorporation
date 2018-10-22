using Accessories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Widgets
{
    public abstract class Widget : IWidgets
    {
        private int _iGears;
        private int _iSprings;
        private int _iLevers;
        private Painted _painted;
        private float _Price;

        public Widget( float Price ) 
        {
            _Price = Price;
            _painted = new Painted();
        }

        protected float Price
        {
            get { return _Price; }
        }

        public int Gears
        {
            get
            {
                return _iGears;
            }
            set
            {
                _iGears = value;
            }
        }
        public int Springs
        {
            get
            {
                return _iSprings;
            }
            set
            {
                _iSprings = value;
            }
        }
        public int Levers
        {
            get
            {
                return _iLevers;
            }
            set
            {
                _iLevers = value;
            }
        }
        public virtual void SetupLevers()
        {

        }
        public virtual void SetupGears()
        {

        }
        public virtual void SetupSprings()
        {

        }

        public void SetupPainted()
        {
            String sPainted;

            Console.Write("Choose an option for the Widget to be painted (Paint, Plated, Plain) ? > ");
            sPainted = Console.ReadLine();
            switch( sPainted )
            {
                case "Plated":
                case "plated":
                    _painted.paint  = Painted.Paint.plated;
                    break;
                case "Paint":
                case "paint":
                    String sColor;

                    _painted.paint = Painted.Paint.painted;
                    Console.Write("What color would you like (Blue, Gold, Green, Orange, Red, Purple) ? > ");
                    sColor = Console.ReadLine();
                    switch(sColor)
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

        public void getPainted()
        {

            if (_painted.paint.Equals(Painted.Paint.painted) == true )
            {
                Console.WriteLine(" Widget is " + _painted.paint.ToString() + " " + _painted.color.ToString());
            }
            else if(_painted.paint.Equals(Painted.Paint.plated ) == true)
            {
                Console.WriteLine(" Widget is " + _painted.paint.ToString() + " and has a surcharge of " + _painted.GetTotalPrice().ToString("C2"));
            }
            else
            {
                Console.WriteLine(" Widget is " + _painted.paint.ToString());
            }

        }

        public void getWidgetOrderSummary()
        {
            if (this.GetType() == typeof(SmallWidget ))
            {
                Console.Write("This is a Small Widget");
            }
            else if (this.GetType() == typeof(MediumWidget ))
            {
                Console.Write("This is a Medium Widget");
            }
            else
            {
                Console.Write("This is a Large Widget");
            }
        }

        public float getWidgetPrice()
        {
            float fTotalPrice = _Price;

            if (_painted.getIsPlated() == true)
            {
                fTotalPrice += _painted.GetTotalPrice();
            }

            return fTotalPrice;
        }
    }

    
}

