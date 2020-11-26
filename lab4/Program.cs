using System;

namespace daylamotproject
{
    class Program
    {
        static void Main(string[] args)
        {
             Pixel[] arrayP = new Pixel[100];
            Console.Write("Nhap so Pixel can xu ly: ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            Console.WriteLine("Nhap Pixel");
            for (int i = 0; i < n; i++)
            {
                arrayP[i] = new Pixel();
                arrayP[i].Set();
            }
            Console.Clear();
            for (int i = 0; i < n; i++)
            {
                arrayP[i].InPixcel();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Cac pixel tren duong cheo chinh: ");
            for (int i = 0; i < n; i++)
                if (arrayP[i].KTCheoChinh())
                {
                    arrayP[i].InPixcel();
                    count++;
                }
            Console.WriteLine("so pixcel tren duong cheo chinh la: " + count + " điểm.");
        }
    }
}
