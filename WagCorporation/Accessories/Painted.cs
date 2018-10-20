using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessories
{
    public class Painted
    {
        private static readonly float _ExPricePlated = 50.00f;
        public enum Paint { painted, plated, plain }
        public enum Colors { Blue, Gold, Green, Orange, Red, Purple}

        private Paint _Paint;
        private Colors _Color;

        public Colors color
        {
            get
            {
                return _Color;
            }
            set
            {
                _Color = value;
            }

        }

        public Paint paint
        {
            get
            {
                return _Paint;
            }
            set
            {
                _Paint = value;
            }

        }

        public float GetTotalPrice()
        {
            if ( paint == Paint.plated )
            {
                return _ExPricePlated;
            }
            else
            {
                return 0.0f;
            }
            
        }

        public bool getIsPlated()
        {
            if ( paint == Paint.plated )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
