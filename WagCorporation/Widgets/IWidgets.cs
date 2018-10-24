using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Widgets
{
    public interface IWidgets
    {
        void SetupGears(bool isRetailOrder);
        void SetupSprings(bool isRetailOrder);
        void SetupLevers(bool isRetailOrder);
    }
}
