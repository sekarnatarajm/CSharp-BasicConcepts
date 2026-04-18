using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon
{
    public class MathCalc
    {
        public ILog log = LazyLog.GetInstance;

        public void Add()
        {
            log.LogInfo("I am plus operator");
        }
    }
}
