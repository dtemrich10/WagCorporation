using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accessories
{
    public class  Powered : iAccessory
    {
        public enum Power { solar, generator, battery}
        private float _Price;

        public Power power
        {
            get
            {
                return power;
            }
            set
            {
                power = value;
                switch (power)
                {
                    case Power.solar:
                        _Price = 20.0f;
                        break;
                    case Power.generator:
                        _Price = 50.0f;
                        break;

                    case Power.battery:
                        _Price = 75.0f;
                        break;
                }
            }
        }

        public string GetTotalPrice()
        {
            return String.Format("{0:C}", _Price);
        }

        public float GetTotalPriceMoney()
        {
                return _Price;
        }

    }
}
