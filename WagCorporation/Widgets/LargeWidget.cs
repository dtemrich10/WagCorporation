using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Widgets
{
    public class LargeWidget : Widget, IWidgets
    {
        public LargeWidget() : base(400.00f)
        {
            Console.WriteLine("Adding a Large widget for " + Price.ToString("C2"));
        }
        public override void SetupGears(bool isRetailOrder)
        {
            if (!isRetailOrder)
            {
                Console.WriteLine("Large widget has nine gears");
            }
            Gears = 9;
        }
        public override void SetupLevers(bool isRetailOrder)
        {
            if (!isRetailOrder)
            {
                Console.WriteLine("Large widget has two lever.");
            }
            Levers = 2;
        }
        public override void SetupSprings(bool isRetailOrder)
        {
            if (!isRetailOrder)
            {
                Console.WriteLine("Large widget has four springs.");
            }
            Springs = 4;
        }
    }
}