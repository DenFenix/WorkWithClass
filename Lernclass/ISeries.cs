using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernclass
{
    interface ISeries
    {
        int getNext();
        void reset();
        void setStart(int x);
    }
}
