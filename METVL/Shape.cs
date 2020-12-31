using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace ConsoleApp13
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
        public abstract float CV();
        public abstract float DT();
        public void OutPut()
        {
            Console.WriteLine("Name:{0} \t CV:{1} \t DT:{2}", name, CV(), DT());
        }
    }
    interface IPaint
    {
        float Cost(int c);
    }

    class Square : Shape,IPaint,IComparable<Square>
    {
        float d, r;
        public const int c1 = 3;
        public Square()
        {
            d = 0;
            r = 0;

        }
        public Square(string name , float d,float r):base(name)
        {
            this.d = d;
            this.r = r;
        }
        public Square (Square s)
        {
            d = s.d;
            r = s.r;
        }
        public override float CV()
        {
            return (d + r) * 2;
        }

        public override float DT()
        {
            return d * r;
        }

        public float Cost(int c)
        {
            return c * DT();
        }
      public static bool operator<(Square q1,Square q2)
        {
            return q1.Cost(c1) < q2.Cost(c1);
        }
        public static bool operator >(Square q1, Square q2)
        {
            return q1.Cost(c1) > q2.Cost(c1);
        }
        public int CompareTo(Square s)
        {
            if (Cost(c1) < s.Cost(c1)) return 1;
            if (Cost(c1) > s.Cost(c1)) return -1;
            return 0;
        }
    }
    class nSquare
    {
        int n, c;
        List<Square> ls = new List<Square>();
        public void Nhap()
        {
            FileStream f = new FileStream("Square.txt", FileMode.Open);
            StreamReader rd = new StreamReader(f, Encoding.UTF8);
            string line;
            try
            {
                while ((line = rd.ReadLine()) != null)
                {
                    string name = line;
                    float d = float.Parse(rd.ReadLine());
                    float r = float.Parse(rd.ReadLine());
                    Square c = new Square(name, d, r);
                    ls.Add(c);
                }
            }
            catch
            {
                Console.WriteLine("Khong doc duoc file da luu");
            }
            n = ls.Count;

        }
        public void Xuat()
        {
            for (int i = 0; i < ls.Count; i++)
            {
                Console.WriteLine("---------------");
                ls[i].OutPut();
                Console.WriteLine("Price: " + ls[i].Cost(c));
            }
        }
        public void SX()
        {
            Console.Write("Nhap Gia: ");
            c = Int32.Parse(Console.ReadLine());
            for (int i=0;i<ls.Count;i++)
                for(int j=i+1;j<ls.Count;j++)
                if(ls[i].Cost(c) < ls[j].Cost(c))
                    {
                        Square tam = new Square();
                        tam = ls[i];
                        ls[i] = ls[j];
                        ls[j] = tam;
                    }
        }
        public void Sort2()
        {
            Console.Write("Nhap Gia: ");
            c = Int32.Parse(Console.ReadLine());
            ls.Sort();
        }
        public void Xoa()
        {
            Console.WriteLine("Nhap dien tich nho hon can xoa");
            float x = float.Parse(Console.ReadLine());
            //tim vi tri can xoa
            for (int i = 0; i < ls.Count; i++)
                if (ls[i].DT() < x)
                {
                    ls.RemoveAt(i); //remove(ls[i]);
                    break;
                }
            Console.WriteLine("Danh sach sau khi xoa la : ");
            Xuat();
        }
        public void Them()
        {
            Console.WriteLine("--------------");
            Console.WriteLine("Vi Tri Can Them: ");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------");
            Console.Write("Nhap Ten Can Them:");
            string name = Console.ReadLine();
            Console.Write("Chieu Dai , Rong:");
            float d = float.Parse(Console.ReadLine());
            float r = float.Parse(Console.ReadLine());
           
            Square q = new Square(name,d,r);
            ls.Insert(i, q);
            Console.WriteLine("Danh sach sau khi Them la : ");
            Xuat();
        }

    }
}
