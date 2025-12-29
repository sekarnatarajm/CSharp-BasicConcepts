using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class AbstractClass
    {
        static AbstractClass()
        {
            Console.WriteLine("Static Print");
        }
        protected AbstractClass()
        {
            Console.WriteLine("AbstractClass constructure");
        }
        protected AbstractClass(int price)
        {
            Console.WriteLine("AbstractClass parameter constructure");
        }
        public void CalculateSalary()
        {
            Console.WriteLine("CalculateSalary");
        }

        public abstract void Salary();
    }

    public class DerivedClass : AbstractClass
    {
        static DerivedClass()
        {
            Console.WriteLine("Static constructure");
        }
        public DerivedClass() 
        {
            Console.WriteLine("Child Print");
        }

        public override void Salary()
        {
             
        }

        public static void Add(params int[] numbers)
        {

        }
    }
    public class StaticConstructure
    {
        static StaticConstructure()
        {
            Console.WriteLine("Static constructure");
        }
        public StaticConstructure()
        {
            Console.WriteLine("Child Print");
        }

        public static void Add(params int[] numbers)
        {

        }
    }
}
