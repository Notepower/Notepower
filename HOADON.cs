using System;
using System.Collections.Generic;
using System.Text;

namespace Daylamotproject2
{
    class Hocphan
    {
        string mahp, tenhp;
        int stc;
        bool loaihp;
        static int hp = 300;
        public int STC { get => stc; set => stc = value; }
        public void Nhap()
        {
            Console.WriteLine("Nhap Thong tin hoc phan: ");
            Console.Write("Ma hoc phan: ");
            mahp = Console.ReadLine();
            Console.Write("Ma ten hoc phan: ");
            tenhp = Console.ReadLine();
            Console.WriteLine("So tin chi cua hoc phan: ");
            stc = int.Parse(Console.ReadLine());
            Console.WriteLine("Loai hoc phan: Thuc Hanh || Ly Thuyet (True || False)");
            loaihp = bool.Parse(Console.ReadLine());



        }
        public double tienhocphi()
        {
            double tien = 0;
            if (loaihp == true)
                tien = stc * hp * 1.5;
            else
                tien = stc * hp;
            return tien;

        }
        public void Xuat()
        {
            Console.WriteLine("MAHP: {0} || TENHP: {1} ||TIENHP: {2}|| ", mahp, tenhp, tienhocphi());
        }
    }
    class HoaDon
    {
        string ms, name;
        Hocphan[] ds;
        public void Nhap()
        {


            ;
            ds = new Hocphan[1];


            for (int i = 0; i < ds.Length; i++)
            {
                Console.Write("Nhap MSSV: ");
                ms = Console.ReadLine();
                Console.Write("Nhap Ten: ");
                name = Console.ReadLine();
                ds[i] = new Hocphan();
                ds[i].Nhap();
            }
        }
        public void Xuat()
        {
            for (int i = 0; i < ds.Length; i++)
            {
                Console.WriteLine("---{0}---{1}---", ms, name);
                ds[i].Xuat();

            }
        }
    }
}
    