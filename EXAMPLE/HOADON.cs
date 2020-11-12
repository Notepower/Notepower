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
        public bool Loaihp { get => loaihp; set => loaihp = value; }
        public void Nhap()
        {
            Console.WriteLine("Nhap Thong tin hoc phan: ");
            Console.Write("Ma hoc phan: ");
            mahp = Console.ReadLine();
            Console.Write("Ma ten hoc phan: ");
            tenhp = Console.ReadLine();
            Console.WriteLine("So tin chi cua hoc phan: ");
            stc = int.Parse(Console.ReadLine());
            Console.WriteLine("Loai hoc phan: T huc Hanh || Ly Thuyet (True || False)");
            loaihp = bool.Parse(Console.ReadLine());



        }
        public double tienhocphi()
        {
            double tien = 0;
            if (loaihp == true)
                tien = stc * hp * 1.5f;
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
        byte shp=0;
        public void Nhap()
        {
            Console.Write("Nhap MSSV: ");
            ms = Console.ReadLine();
            Console.Write("Nhap Ten: ");
            name = Console.ReadLine();
            Console.WriteLine("Nhap so hoc phan: ");
            shp = byte.Parse(Console.ReadLine());
            ds = new Hocphan[shp];
            for (int i = 0; i < ds.Length; i++)
            {
                
                ds[i] = new Hocphan();
                ds[i].Nhap();
            }
        }
        public void Xuat()
        {
            Console.WriteLine("---{0}---{1}---", ms, name);
            for (int i = 0; i < ds.Length; i++)
            {
                ds[i].Xuat();

            }
        }
        public byte Tinh_TH()
        {
            byte d = 0;
            foreach (Hocphan hp in ds)
                if (hp.Loaihp == true) //thực hành
                    d = (byte)(d + hp.STC);
            return d;
        }

    }
}
