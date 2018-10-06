using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadgets
{
    public interface IGadget
    {
        void SetupWidgets();
        void SetupLights();
        void SetupSwitches();
        void SetupButtons();
    }
}
