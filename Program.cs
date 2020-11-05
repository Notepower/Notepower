using System;

namespace Daylamotproject2
{
    class program
    {
        static void Main(string[] args)
        {
            /*HoaDon hd = new HoaDon();
            hd.Nhap();
            hd.Xuat();
            */
            BAI3 gio = new BAI3();
            gio.Nhap();
            gio.Show24();
            gio.Show12();
            gio.CongPhut();
        }
    }
}
