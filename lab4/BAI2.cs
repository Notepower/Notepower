using System;
using System.Collections.Generic;
using System.Text;

namespace daylamotproject
{
    class Colour
    {
        protected int colour;
        public Colour()
        {
            colour = 0;
        }
        public Colour(int c1)
        {
            colour = c1;
        }
    }
    class Pixel : Colour
    {
        int x, y;
        public Pixel()
        {
            x = 0; y = 0;
        }
        public Pixel(int x1, int y1, int c1) : base(c1)
        {
            x = x1; y = y1;
        }
        public void Set()
        {
            Console.Write("Nhập màu của pixel: ");
            colour = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập tọa độ của pixel: ");
            Console.Write("x = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            y = Convert.ToInt32(Console.ReadLine());
        }
        public bool KTCheoChinh()
        {
            return x == y;
        }   
        public void InPixcel()
        {
            Console.ForegroundColor = (ConsoleColor)colour;
            Console.CursorTop = y;
            Console.CursorLeft = x;
            Console.Write("o");
        }
    }
}
