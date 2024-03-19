using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    internal class Apple
    {
        #region Fields

        float amountLeft;
        bool organic;

        #endregion

        #region Properties

        public float AmountLeft
        {
            get { return amountLeft; }
        }

        public bool Organic
        {
            get { return organic; }
        }

        #endregion

        #region Constructors

        public Apple() : this(100f, true)
        {
        }

        public Apple(float amountLeft, bool organic)
        {
            this.amountLeft = amountLeft;
            this.organic = organic;
        }

        #endregion

        #region Methods
           
        public void TakeBite(float size)
        {
            if(amountLeft - size > 0)
                amountLeft -= size;
            else amountLeft = 0;
        }

        #endregion
    }
}
