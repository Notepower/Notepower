using System;
using System.Collections.Generic;
using System.Text;

namespace Daylamotproject2
{
    class BAI3
    {
        private int h;
        private int m;
        private int s;


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
        /*public void CongPhut()
        {
            byte mplus;
            int m1 = 0;
            int h1 = 0;
            Console.WriteLine("Nhap so phut can cong: ");
            mplus = byte.Parse(Console.ReadLine());
           
            
                h1 = h + (m + mplus) / 60;
                m1 = m1 + (m + mplus) % 60;
            
            if (h1 > 12)
                Console.WriteLine("{0}PM:{1}p:{2}s", h1 - 12, m1, s);
            else
                Console.WriteLine("{0}AM:{1}p:{2}s", h1, m1, s);

        }
        */
        public void Congphut()
        {
            Console.Write("Nhap phut can cong: ");
            m = int.Parse(Console.ReadLine());
        }
        public static BAI3 operator + (BAI3 t1 ,BAI3 t2)
        {
            BAI3 mplus = new BAI3();
            mplus.h = t1.h + t2.h;
            mplus.m = t1.m + t2.m;
            mplus.s = t1.s + t2.s;

            return mplus;
            
        }
        public override string ToString()
        {
            return string.Format("{0}:{1}:{2}",h+m/60,m%60,s);
        }
    }
}