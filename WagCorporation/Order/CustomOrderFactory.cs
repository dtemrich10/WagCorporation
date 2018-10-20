using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class CustomOrderFactory : OrderFactory
    {
        public override void Build()
        {
            CustomOrder co = new CustomOrder(isRetailOrder);
            co.Build();
        }
    }
}
