using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_01
{
    class GiangVienTG: GiangVien
    {
        private int sotietday;

        public GiangVienTG() : base()
        {
        }
        public GiangVienTG(string maso, string hoten, int namsinh, int sotietday) : base(maso, hoten, namsinh)
        {
            this.sotietday = sotietday;
        }

        public int SoTietDay
        {
            set { sotietday = value; }
            get { return sotietday; }
        }
        public override int tinhLuong()
        {
            return sotietday * 80000;
        }
    }
}
