using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_01
{
    class GiangVienCH : GiangVien
    {
        private double hesoluong;

        public GiangVienCH(string v) : base() {            
        }
        public GiangVienCH(string maso, string hoten, int namsinh, double hesoluong) : base(maso,hoten,namsinh)
        {
            this.hesoluong = hesoluong;
        }

        public double HeSoLuong {
            set { hesoluong = value; }
            get { return hesoluong; }
        }

        public override int tinhLuong()
        {
            double luong = hesoluong * 1800000;
            return (int)luong;
        }
    }
}
