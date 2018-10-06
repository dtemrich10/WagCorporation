using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadgets
{
    public class Gadget : IGadget
    {
        private List<Object> widgets = new List<object>();
        private int _iSwitches;
        private int _iButtons;
        private int _iLights;

        protected int Switches
        {
            get
            {
                return _iSwitches;
            }
            set
            {
                _iSwitches = value;
            }
        }
        protected int Buttons
        {
            get
            {
                return _iButtons;
            }
            set
            {
                _iButtons = value;
            }
        }
        protected int Lights
        {
            get
            {
                return _iLights;
            }
            set
            {
                _iLights = value;
            }
        }

        public virtual void SetupWidgets()
        {
        }

        public virtual void SetupLights()
        {
        }

        public virtual void SetupSwitches()
        {
        }

        public virtual void SetupButtons()
        {

        }

    }
}
