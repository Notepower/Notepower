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
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
             Console.WriteLine("Cac pixel tren duong cheo chinh: ");
             for (int i = 0; i < n; i++)
                 if (arrayP[i].KTCheoChinh())
                 {
                     arrayP[i].InPixcel();
                     count++;
                 }
             Console.WriteLine("so pixcel tren duong cheo chinh la: " + count + " điểm.");
             /*
            Guest[] Flight;
            byte n;
            Console.Write("How many guest: ");
            n = byte.Parse(Console.ReadLine());
            Flight = new Guest[n];
            Console.WriteLine("---------------------------");
            Console.WriteLine("----Enter Information----");
            for(int i=0;i<n;i++)
            {
                Flight[i] = new Guest();
                Console.WriteLine("------Guest {0} ------", i + 1);
                Flight[i].Set();
            }
            Console.WriteLine("---------------------------");
            Console.Clear();
            Console.WriteLine("----Guest Information----");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Guest {0} ", i + 1);
                Console.WriteLine("---------------");
                Flight[i].Get();
            }
            Console.ReadKey();
            Console.Clear();
            Console.Write("------------------------------------------------------------------------------");
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (Flight[j].SumPrice() < Flight[j + 1].SumPrice())
                    {
                        Guest temp = Flight[j];
                        Flight[j] = Flight[j + 1];
                        Flight[j + 1] = temp;
                    }
            Console.WriteLine("\t\t\n\nGuest after Sort");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\t\nGuest {0}", i + 1);
                Flight[i].Get();
            }
            Console.Write("------------------------------------------------------------------------------");
            */
            Console.ReadKey();
            

        }
    }
}
