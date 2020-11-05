using System;
using System.Collections.Generic;
using System.Text;

namespace Daylamotproject2
{
    class BAI3
    {
        byte h = 0, m = 0, s = 0;
        public void Nhap()
        {
            Console.Write("Nhap Gio: ");
            h = byte.Parse(Console.ReadLine());
            Console.Write("Nhap Phut: ");
            m = byte.Parse(Console.ReadLine());
            Console.Write("Nhap Giay: ");
            s = byte.Parse(Console.ReadLine());
        }
        public void Show24()
        {
            Console.WriteLine("Dinh Dang 24h: ");
            Console.WriteLine("{0}h:{1}p:{2}s", h, m, s);
        }
        public void Show12()
        {
            Console.WriteLine("Dinh Dang 12h: ");
            if (h > 12)
                Console.WriteLine("{0}PM:{1}p:{2}s", h - 12, m, s);
            else
                Console.WriteLine("{0}AM:{1}p:{2}s", h, m, s);
        }
        public void CongPhut()
        {
            byte mplus;
            int m1 = 0;
            int h1 = 0;
            Console.WriteLine("Nhap so phut can cong: ");
            mplus = byte.Parse(Console.ReadLine());
           
            if (m+mplus>60)
            {
                h1 = h + (m + mplus) / 60;
                m1 = m1 + (m + mplus) % 60;
            }
            if (h1 > 12)
                Console.WriteLine("{0}PM:{1}p:{2}s", h1 - 12, m1, s);
            else
                Console.WriteLine("{0}AM:{1}p:{2}s", h1, m1, s);

        }

    }
}
