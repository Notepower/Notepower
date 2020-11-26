using System;

namespace daylamotproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Pixel[] arrayP = new Pixel[100];
            Console.Write("Nhập số pixel cần xử lý: ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            Console.WriteLine("\t\t\n\nNHẬP PIXEL");
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
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\nCác pixel trên đường chéo chính: ");
            for (int i = 0; i < n; i++)
                if (arrayP[i].KTCheoChinh())
                {
                    arrayP[i].InPixcel();
                    count++;
                }
            Console.WriteLine("Số pixel trên đường chéo chính là: " + count + " điểm.");
        }
    }
}
