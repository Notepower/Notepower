using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace BAIKT
{
    abstract class Shape
    {
        string name;
        public Shape()
        {
            name = "";
        }
        public Shape(string name)
        {
            this.name = name;
        }
        public Shape(Shape a)
        {
            name = a.name;
        }
        public abstract double CV();
        public abstract double DT();
        public void Output()
        {
            Console.Write("Name: {0} \t CV: {1} \t S: {2} \t", name, CV(), DT());
        }
    }
    interface IPaint
    {
        float Cost(int c);
    }
    class Square : Shape,IPaint
    {
        float d;
        float r;
        public Square() : base()
        {
            d = 0;
            r = 0;
        }
        public Square(string name, float d,float r) : base(name)
        {
            this.d = d;
            this.r = r;
        }

        public Square(Square a)
        {
            d = a.d;
            r = a.r;
        }

       

        public override double CV()
        {
            return (d + r) * 2;
        }
        public override double DT()
        {
            return d * r;
        }
        public float Cost(int c)
        {
            return c * (float)DT();
        }
    }
    class nSquare
    {
        int n, c;
        List<Square> ds = new List<Square>();
        public void Nhap()
        {
            FileStream f = new FileStream("Square.txt", FileMode.Open);
            StreamReader rd = new StreamReader(f, Encoding.UTF8);
            n = Convert.ToInt32(rd.ReadLine());
            c = Convert.ToInt32(rd.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string name = rd.ReadLine();
                float d = Convert.ToInt64(rd.ReadLine());
                float r = Convert.ToInt64(rd.ReadLine());
                Square a = new Square(name,d,r);
                ds.Add(a);
                f.Close();
            }
            for (int i = 0; i < n; i++)
            {
                ds[i].Output();
                Console.WriteLine("Price: " + ds[i].Cost(c));
            }
        }
        public void Xoa()
        {
            List<Square> a = new List<Square>(ds);
            float x = Convert.ToSingle(Console.ReadLine());
            for (int i = 0; i <= n; i++)
                if (a[i].DT() < x)
                {
                    a.RemoveAt(i);
                    return;
                }
        }
       
    }
}

