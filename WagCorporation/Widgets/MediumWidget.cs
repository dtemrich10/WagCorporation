using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Widgets
{
    public class MediumWidget: Widget, IWidgets
    {
        public MediumWidget() : base(250.00f)
        {
            Console.WriteLine("Adding a medium widget for " + Price.ToString("C2"));
        }
        public override void SetupGears()
        {
            Console.WriteLine("Medium widget has four gears");
            Gears = 4;
        }
        public override void SetupLevers()
        {
            Console.WriteLine("Medium widget has three levers.");
            Levers = 3;
        }
        public override void SetupSprings()
        {
            Console.WriteLine("Medium widget has five springs.");
            Springs = 5;
        }

    }
}
