using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.CodeAnalysis;

namespace DAYLA1PROJECT
{
    class Chuoi
    {
        string s;
        int col, row;

        public void chuoi ()
        {
            s = "hello everyone";
            col = 3;
            row = 4;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;

        }
        public void chuoi (string s1="hello everyone" , int c=0 ,int r=0)
        {
            s = s1;
            col = c;
            row = r;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
        }
        public void HienThi()
        {
            Console.Clear();// xoa man hinh;
            Console.CursorVisible = false; // an con tro
            Console.CursorTop = row; // dua con tro toi row ,col;
            Console.CursorLeft = col;
            Console.Write(s);
        }
        public void Move()
        {
            HienThi();
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Escape)
                    break;
                if (key.Key == ConsoleKey.LeftArrow)
                    col--;
                else if (key.Key == ConsoleKey.RightArrow)
                    col++;
                else if (key.Key == ConsoleKey.UpArrow)
                    row--;
                else if (key.Key == ConsoleKey.DownArrow)
                    row++;

                //xu ly bien
                if (col < 0)
                    col = Console.WindowWidth;
                if (col >= Console.WindowWidth)
                    col = 0;
                if (row <= 0)
                    row = Console.WindowHeight;
                if (row >= Console.WindowHeight)
                    row = 0;
                HienThi();

            }
        }
    }
}
