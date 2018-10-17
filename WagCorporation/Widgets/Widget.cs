using Accessories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Widgets
{
    public class Widget : IWidgets
    {
        private int _iGears;
        private int _iSprings;
        private int _iLevers;
        private Painted _painted;
        private float _Price;

        public Widget( float Price)
        {
            _Price = Price;
            _painted = new Painted();
        }

        protected int Gears
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
        protected int Springs
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
        protected int Levers
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

            Console.Write("Choose an option for the Widget to be painted (Paint, Plated, Plain) ");
            sPainted = Console.ReadLine();
            switch( sPainted )
            {
                case "Plated":
                    _painted.paint  = Painted.Paint.plated;
                    break;
                case "Paint":
                    String sColor;

                    _painted.paint = Painted.Paint.plated;
                    Console.Write("What color would you like (Blue, Gold, Green, Orange, Red, Purple) ? ");
                    sColor = Console.ReadLine();
                    switch(sColor)
                    {
                        case "Blue":
                            _painted.color = Painted.Colors.Blue;
                            break;
                        case "Green":
                            _painted.color = Painted.Colors.Green;
                            break;
                        case "Orange":
                            _painted.color = Painted.Colors.Orange;
                            break;
                        case "Red":
                            _painted.color = Painted.Colors.Red;
                            break;
                        case "Purple":
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

        public string getPainted()
        {
            string sPainted = "Wideget is ";

            return sPainted;
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

