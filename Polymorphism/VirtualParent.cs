using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class VirtualParent
    {
        public virtual void Add()
        {
            Console.WriteLine("Base.Print");
        }
    }

    public class VirtualChild : VirtualParent
    {
        public override void Add()
        {
            Console.WriteLine("Child.Print");
        }
    }
}
