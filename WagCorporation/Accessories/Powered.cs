using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accessories
{
    public class Powered : iAccessory
    {
        public enum Power { battery = 0, solar = 1, generator = 2 }
        public float[] PowerPrice = { 20.0f, 50.0f, 75.0f };
        private float _Price;

        private Power _Power;

        public Power DefaultPower {get; set;}

        public Power power
        {
            get
            {
                return _Power;
            }
            set
            {
                _Power = value;
                switch (_Power)
                {
                    case Power.solar:
                        _Price = PowerPrice[(int)Power.solar];
                        break;
                    case Power.generator:
                        _Price = PowerPrice[(int)Power.generator];
                        break;

                    case Power.battery:
                        _Price = PowerPrice[(int)Power.battery];
                        break;
                }
            }
        }

        public string GetTotalPrice()
        {
            return String.Format("{0:C}", _Price);
        }

        //this returns that difference to be added
        public float GetTotalPriceMoney()
        {
            float fdifference = 0.0f;

            if (_Power == Power.battery)
            {
                return fdifference;
            }

            if ( _Power == Power.solar )
            {
                if (DefaultPower == Power.battery)  // this means we're setting a medium widget
                {
                    fdifference = PowerPrice[(int)Power.solar] - PowerPrice[(int)Power.battery];
                }

                return fdifference;
            }

            if (_Power == Power.generator )
            {
                fdifference = PowerPrice[(int)Power.solar] - PowerPrice[(int)Power.generator];
                return fdifference;
            }

            return fdifference;
        }

    }
}
