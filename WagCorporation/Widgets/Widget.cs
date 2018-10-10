using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WagCorporation
{
    public class Widget : IWidgets
    {
        private int _iGears;
        private int _iSprings;
        private int _iLevers;
        public enum _paint { plain, plated, painted }

        public Widget()
        {
        }
        protected int Gears
        {
            get
            {
                return _iGears;
            }
            set
            {
                _iGears = value;
            }
        }
        protected int Springs
        {
            get
            {
                return _iSprings;
            }
            set
            {
                _iSprings = value;
            }
        }
        protected int Levers
        {
            get
            {
                return _iLevers;
            }
            set
            {
                _iLevers = value;
            }
        }
        public virtual void SetupLevers()
        {

        }
        public virtual void SetupGears()
        {

        }
        public virtual void SetupSprings()
        {

        }
    }

    
}

