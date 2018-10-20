using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class RetailOrder : IOrder
    {
        public bool isRetailOrder { get; set; }

        public RetailOrder( bool bRetailOrder )
        {
            isRetailOrder = bRetailOrder;
        }

        public void Build()
        {
            Console.WriteLine("retail");
        }

    }
}
