
namespace Polymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            object obj = "";
            int? fdf = obj as int?;


            object o = "hello";
            string? s1 = o as string;   // "hello"


            object o = "hello";
            bool result = o is string;        // true
            bool result2 = o is int;          // false



            StaticConstructure.Add(5);
            StaticConstructure.Add(6);
            StaticConstructure.Add(7);
            StaticConstructure.Add(8);

            DerivedClass derivedClass = new DerivedClass();
            derivedClass.CalculateSalary();

            DerivedClass derivedClass1 = new DerivedClass();
            derivedClass1.CalculateSalary();

            DerivedClass derivedClass2 = new DerivedClass();
            

            VirtualParent virtualParent = new VirtualParent();
            virtualParent.Add();

            VirtualParent virtualParent1 = new VirtualChild();
            virtualParent1.Add();

            VirtualChild VvirtualChild = new VirtualChild();
            VvirtualChild.Add();

            Console.ReadKey();
        }
    }
}