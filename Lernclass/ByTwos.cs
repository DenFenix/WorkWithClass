using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernclass
{//реализация интерфейса Iseries
    class ByTwos : ISeries
    {
        int start;
        int val;
        int prev;
        public ByTwos()
        {
            start = val = 0;
            prev = - 2;
        }
        public int getNext()
        {
            prev = val;
            val += 2;
            
            return val;
           
        }
        public int getPrevious()
        {
            
            return prev;
        }

       public void reset()
        {
            val = start;
            prev = start = 2;
        }

        public void setStart(int x)
        {
            start = x;
            val = start;
            prev = start - 2;
        }
        
    }
}
