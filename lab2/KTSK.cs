using System;
using System.Collections.Generic;
using System.Text;

namespace DAYLA1PROJECT
{
    class KTSK
    {
        string name;
        float weight, height;
        public void Nhap()
        {
            Console.WriteLine("Nhap ten:");
            name = Console.ReadLine();
            Console.WriteLine("Nhap can nang:");
            while (float.TryParse(Console.ReadLine(), out weight)==false )
                Console.WriteLine("Nhap lai");
            Console.WriteLine("Nhap chieu cao:");
            while (float.TryParse(Console.ReadLine(), out height) == false)
                Console.WriteLine("Nhap lai");
        }
        public void Xuat ()
        {
            Console.WriteLine("{0} || {1}kg || {2}m", name, weight, height);
            float BMI = weight / (height*height);
            Console.Write("Status: ");
            if (BMI < 18.5) Console.Write("Thieu can");
            if (BMI >= 18.5 && BMI <= 25) Console.Write("Binh thuong");
            if (BMI > 25 && BMI < 30) Console.Write("Thua can");
            if (BMI >= 30) Console.Write("Beo Phi");
            Console.Write("\n");
        }
        public void advice()
        {
            double BMI1, BMI2;
            double giam = 1, tang = 1;
            float BMI = weight / (height * height);
            if (BMI>25)
            {
                BMI1 = BMI - 25;
                giam = BMI1 * (height * height);
               Console.WriteLine("Ban can giam {0:0.00}kg ", giam);
            }
            else if (BMI<18.5)
            {
                BMI2 = 18.5 - BMI;
                tang = BMI2 * (height * height);
                Console.WriteLine("Ban can tang {0:0.00}kg ", tang);
            }

        }
}
    }
