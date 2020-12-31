using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Danh Sach HCN:");
            nSquare n = new nSquare();
            n.Nhap();
            n.Sort2();
            n.Xuat();
            n.Xoa();
            n.Them();
            Console.ReadKey();
        }
    }
}
