using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_01
{
    class QuanLyGV
    {
        private List<GiangVien> ds;
        public QuanLyGV() {
            ds = new List<GiangVien>();
        }

        public void Nhap() {
            GiangVien tam;
            tam = new GiangVienCH("01", "Minh", 1960, 4.95);
            ds.Add(tam);
            tam = new GiangVienCH("02", "Thanh", 1976, 4.36);
            ds.Add(tam);
            tam = new GiangVienTG("03", "Tan", 1966, 50);
            ds.Add(tam);
        }

        public void Xuat()
        {
            Console.WriteLine($"{"Maso",10}  {"HoTen",20}  {"NamSinh",10}  {"Luong",20}");
            foreach (GiangVien x in ds) {
                Console.WriteLine($"{x.MaSo,10}  {x.HoTen,20}  {x.NamSinh,10}  {x.tinhLuong(),20:#,##0 vnd}");
            }
        }
    }
}
