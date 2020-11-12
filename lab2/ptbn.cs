using System;
using System.Collections.Generic;
using System.Text;

namespace DAYLA1PROJECT
{
    class ptbn
    {
       short a, b;

        //nhap gia tri a,b;
        public void Nhap()
        {
            Console.WriteLine("Nhap a");
            while (Int16.TryParse(Console.ReadLine(),out a) == false)
                Console.WriteLine("Nhap lai a");
            Console.WriteLine("Nhap b");
            while (Int16.TryParse(Console.ReadLine(), out b) == false)
                Console.WriteLine("Nhap lai b");
        }
        public void Giai ()
        {
            if (a == 0)
                if (b == 0) Console.WriteLine("PTVSN");
                else
                    Console.WriteLine("PTVN");
            else
                Console.WriteLine("Nghiem cua phuong trinh la {0}", (float)-b / a);

        }

    }
}
