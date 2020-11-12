using System;
using System.Collections.Generic;
using System.Text;

namespace DAYLA1PROJECT
{
    class bai2_2
    {
        int n;
        int[]a;
        public void nhap()
        {
            Console.WriteLine("Nhap so phan tu");
        while (int.TryParse(Console.ReadLine(), out n) == false || n<3 || n>20)
                Console.WriteLine("Nhap lai");
            Console.WriteLine("Nhap phan tu cua mang: ");
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        public void Xuat()
        {
            for (int i=0;i<n;i++)
                Console.Write(a[i] + " ");
            Console.WriteLine("\n");
        }
        public void TBC()
        {
            int s=0;
            foreach (int i in a)
            {
                s = s + i;
            }
            Console.WriteLine("TBC la {0}", (float)s / a.Length);
        }
        public void HV (ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public void SX()
        {
            Console.WriteLine("Mang vua sap xep la");
            for (int i = 0; i < n-1; i++)
            {
                for (int j =0; j < n-1; j++)
                    if (a[j] > a[j + 1])
                        HV(ref a[j], ref a[j + 1]);
            }
            Xuat();

        }

    }
}
            
