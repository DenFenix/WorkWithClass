using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernclass
{
    class SimpProp
    {
        int prop; //это поле управляет свойством mypyp;
        public SimpProp()
        {
            prop = 0;
        }
            
        public int mypop
        {
            get
            {
                return prop;
            }
            set
            {
                if (value >= 0)
                    prop = value;
            }
        }
    }
}
