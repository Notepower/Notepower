using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            //BAI 4.2

            /*Student s = new Student();
            s.Set();
            s.Get();*/

            //BAI 4.3

            /*Pixel[] arrayP = new Pixel[100];
            Console.Write("Nhập số pixel cần xử lý: ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            Console.WriteLine("\t\t\n\nNHẬP PIXEL");
            for (int i = 0; i < n; i++)
            {
                arrayP[i] = new Pixel();
                arrayP[i].Set();
            }
            Console.WriteLine("\t\t\n\nXUẤT PIXEL");
            for (int i = 0; i < n; i++)
            {
                arrayP[i].InPixcel();
            }
            Console.WriteLine("\t\nCác pixel trên đường chéo chính: ");
            for (int i = 0; i < n; i++)
                if (arrayP[i].KTCheoChinh())
                {
                    arrayP[i].InPixcel();
                    count++;
                }
            Console.WriteLine("Số pixel trên đường chéo chính là: " + count + " điểm.");*/

            /* HanhKhach k1 = new HanhKhach();
            k1.Set();
            k1.Get();*/
            HanhKhach[] k = new HanhKhach[10];
            int n;
            Console.Write("Nhập số hành khách xử lý: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("------------------------------------------------------------------------------");
            Console.WriteLine("\t\t\n\nNHẬP THÔNG TIN HÀNH KHÁCH");
            for (int i = 0; i < n; i++)
            {
                k[i] = new HanhKhach();
                Console.WriteLine("\t\nNHẬP HÀNH KHÁCH THỨ {0}", i + 1);
                k[i].Set();
            }
            Console.Write("------------------------------------------------------------------------------");
            Console.WriteLine("\t\t\n\nTHÔNG TIN HÀNH KHÁCH");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\t\nHÀNH KHÁCH THỨ {0}", i + 1);
                k[i].Get();
            }
            Console.Write("------------------------------------------------------------------------------");
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (k[j].TongTien() > k[j + 1].TongTien())
                    {
                        HanhKhach temp = k[j];
                        k[j] = k[j + 1];
                        k[j + 1] = temp;
                    }
            Console.WriteLine("\t\t\n\nTHÔNG TIN HÀNH KHÁCH SAU KHI SẮP XẾP");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\t\nHÀNH KHÁCH THỨ {0}", i + 1);
                k[i].Get();
            }
            Console.Write("------------------------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}
