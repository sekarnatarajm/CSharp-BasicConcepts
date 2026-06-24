using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("Base");
        }
    }
    public class DerivedClass : BaseClass
    {
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Derived");
        }
    }
}
