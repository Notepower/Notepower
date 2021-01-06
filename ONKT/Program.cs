using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            nCreditCard n = new nCreditCard();
            n.Input();
            n.Paid(2, 2000);
            //n.SX();
            n.Output();
            //n.Delete();
            
            Console.ReadKey();
        }
    }
}
