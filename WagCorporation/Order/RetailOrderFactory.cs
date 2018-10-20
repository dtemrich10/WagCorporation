using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class RetailOrderFactory : OrderFactory
    {
        public override void Build()
        {
            RetailOrder ro = new RetailOrder(isRetailOrder);
            ro.Build();
        }
    }
}
