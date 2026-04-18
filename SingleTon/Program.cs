using SingleTon;
using System;

namespace CSharp_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ILog log = LazyLog.GetInstance;
            //log.LogInfo("I am a happy");

            MathCalc mathCalc = new MathCalc();
            mathCalc.Add();
            Console.ReadKey();
        }
    }
}
