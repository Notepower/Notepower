using System;
using System.Collections.Generic;
using System.Text;

namespace DAYLAMOTPROJECT22
{
    class Last
    {
        private double tu;
        private double mau;
        private double kq;

        public void setPS()
        {
            Console.Write("Nhap phan tu: ");
            tu =int.Parse(Console.ReadLine());
            Console.Write("Nhap phan mau: ");
            mau = int.Parse(Console.ReadLine());
        }
        public void XuatPS()
        {
            Console.Write("Phan so vua nhap la :{0}/{1}",tu,mau);
            Console.Write("\n");

        }
        public static Last operator + (Last x1, Last x2)
        {
            Last ps = new Last();
            ps.tu = x1.tu * x2.mau + x2.tu * x1.mau;
            ps.mau = x1.mau * x2.mau;
            ps.kq = (float)ps.tu / ps.mau;

            return ps;
        }

        public static Last operator -(Last x1, Last x2)
        {
            Last ps = new Last();
            ps.tu = x1.tu * x2.mau - x2.tu * x1.mau;
            ps.mau = x1.mau * x2.mau;
            ps.kq = (float)ps.tu / ps.mau;

            return ps;
        }
        public static Last operator *(Last x1, Last x2)
        {
            Last ps = new Last();
            ps.tu = x1.tu * x2.tu;
            ps.mau = x1.mau * x2.mau;
            ps.kq = (float)ps.tu / ps.mau;

            return ps;
        }
        public static Last operator / (Last x1, Last x2)
        {
            Last ps = new Last();
            ps.tu = x1.tu * x2.mau;
            ps.mau = x1.mau * x2.tu;
            ps.kq = (float)ps.tu / ps.mau;

            return ps;
        }
        public override string ToString()
        {
            return string.Format("{0:0.00}",kq);
        }
    }
}
