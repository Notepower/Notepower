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

            Console.WriteLine("---------------------");
            BAI3 t1 = new BAI3();
            BAI3 t2 = new BAI3();

            t1.Nhap();
            t2.Congphut();

            Console.WriteLine("Cong phut {0}", t1+t2);

            /*
           DAYLAMOTPROJECT22.Last ps1 = new DAYLAMOTPROJECT22.Last();
            DAYLAMOTPROJECT22.Last ps2 = new DAYLAMOTPROJECT22.Last();
            

            ps1.setPS();
            ps1.XuatPS();
           
            ps2.setPS();
            ps2.XuatPS();


            //cong 2 phan so
            Console.WriteLine("Tong 2 phan so la {0}", ps1+ps2);
            //tru 2 phan so
          
            Console.WriteLine("Hieu 2 phan so la {0}", ps1-ps2);
            //nhan 2 phan so
            
            Console.WriteLine("Tich 2 phan so la {0}", ps1*ps2);
            //Chia 2 phan so
            
            Console.WriteLine("Thuong 2 phan so la {0}", ps1/ps2);
            */


        }
    }
}
