using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_01
{
    class Program
    {
        static void Main(string[] args)
        {
            QuanLyGV ql = new QuanLyGV();
            ql.Nhap();
            ql.Xuat();
            Console.ReadLine();
        }
    }
}
