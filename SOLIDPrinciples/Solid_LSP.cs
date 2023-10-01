using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples
{
    public class AnountTransfer
    {
        public virtual void Transfer()
        {
            Console.WriteLine("Base Method");
        }
    }
    public class IMPS : AnountTransfer
    {
        public override void Transfer()
        {
            Console.WriteLine("IMPS");
        }
    }
    public class NEFT : AnountTransfer
    {
        public override void Transfer()
        {
            Console.WriteLine("NEFT");
        }
    }
    public class RTGS : AnountTransfer
    {
        public override void Transfer()
        {
            Console.WriteLine("RTGS");
        }
    }
}
