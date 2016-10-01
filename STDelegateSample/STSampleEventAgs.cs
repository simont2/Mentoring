using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STDelegateSample
{
    public class STSampleEventAgs : EventArgs
    {
        public int CounterValue = 0;
        public STSampleEventAgs(int counterValue)
        {
            CounterValue = counterValue;
        }
    }
}
