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
        double USC(double a, double b)
        {
            a = Math.Abs(a);//trị tuyệt đối của a
            b = Math.Abs(b);
            while (a != b)
                if (a > b)
                    a = (a - b);
                else
                    b = (b - a);
            return a;
        }
        public override string ToString()
        {
            return string.Format("{0}/{1} = {2:0.00}",tu,mau, kq);
        }
        public Last RutGon()
        {
            Last kq = new Last();
            kq.tu = (short)(tu / USC(tu, mau));
            kq.mau = (short)(tu / USC(tu, mau));
            return kq;
        }
        public void Xuat()
        {
            Console.WriteLine("{0}/{1}", tu, mau);
        }

    }
}
