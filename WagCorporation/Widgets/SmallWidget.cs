using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Widgets
{
   public class SmallWidget : Widget, IWidgets
   { 
        public SmallWidget() : base(100.00f)
        {
            Console.WriteLine("Adding a small widget for " + Price.ToString("C2"));
        }
        public override void SetupGears()
        {
            Console.WriteLine("Small widget has two gears");
            Gears = 2;
        }
        public override void SetupLevers()
        {
            Console.WriteLine("Small widget has one lever.");
            Levers = 1;
        }
        public override void SetupSprings()
        {
            Console.WriteLine("Small widget has three springs.");
            Springs = 3;
        }

    }
}
