using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DANH SACH TAI KHOAN");
            nPersonalAccount n = new nPersonalAccount();
            n.Input();
            n.Output();
            /*
            Console.Write("Tai khoan can nap:");
            byte t = byte.Parse(Console.ReadLine());
            Console.Write("So Tien can nap:");
            int m = int.Parse(Console.ReadLine());
            n.Add(t,m);
            */
            n.SX();
            Console.Write("NHAP TAI KHOAN CAN KIEM TRA:");
            string stk = Console.ReadLine();
            n.Check(stk);
            Console.ReadKey();

        }
    }
}
