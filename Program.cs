using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAIKT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            nSquare s = new nSquare();
            Console.WriteLine("\t\tDanh sách các HCN:");
            s.Nhap();
            s.Xoa();
            Console.ReadKey();
        }
    }
}
