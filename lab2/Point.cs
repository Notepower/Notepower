using System;
using System.Collections.Generic;
using System.Text;

namespace DAYLA1PROJECT
{
    class Point
    {
        int x;
        int y;
    public void Nhap()
        {
            Console.WriteLine("Nhap toa do x: ");
            while (int.TryParse(Console.ReadLine(),out x ) == false )
            {
                Console.WriteLine("Nhap lai");

            }
            Console.WriteLine("Nhap toa do y: ");
            while (int.TryParse(Console.ReadLine(), out y) == false)
            {
                Console.WriteLine("Nhap lai");

            }

        }
     public void Set(int x1,int y1)
        {
            x = x1;
            y = y1;

        }
      public void Info()
        {
            Console.WriteLine("x={0} , y={1}", x, y);
                    
        }
        // khoang cach
      public double Distance (Point p)
        {
            return Math.Sqrt((p.x - x) * (p.x - x) + (p.y - y) * (p.y - y));
        }

    }
}
