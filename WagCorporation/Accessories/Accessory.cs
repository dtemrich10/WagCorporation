using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accessories
{
  public class Accessory : iAccessory
    {
       private int _iQuantity;
        private float _fPrice;

        public int Quantity
        {
            get
            {
                return _iQuantity;
            }
            set
            {
                _iQuantity = value;
            }
        }

        public float Price
        {
            get
            {
                return _fPrice;
                
            }
            set
            {
                _fPrice = value;
            }
        }

        public float GetTotalPriceMoney()
        {
            float fTotalPrice = _iQuantity * _fPrice;
            return fTotalPrice;
        }

        public string GetTotalPrice()
        {
            float fTotalPrice = _iQuantity * _fPrice;
            string sPrice = String.Format("{0:C}", fTotalPrice);
            return sPrice;
        }
    }
}
