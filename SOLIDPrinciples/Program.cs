using System;

namespace SOLIDPrinciples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LSP
            AnountTransfer anountTransfer = new AnountTransfer();
            anountTransfer.Transfer();

            AnountTransfer imps = new IMPS();
            imps.Transfer();
            Console.WriteLine("Hello World!");
        }
    }
}
