using System;

namespace QLNV
{
    class NhanVien
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public double LuongCoBan { get; set; }

        public NhanVien() { }

        public NhanVien(string ma, string ten, double luong)
        {
            MaNV = ma ?? "";
            TenNV = ten ?? "";
            LuongCoBan = luong >= 0 ? luong : 0;
        }

        public virtual void Nhap()
        {
            Console.Write("Ma NV: ");
            MaNV = Console.ReadLine() ?? "";

            Console.Write("Ten NV: ");
            TenNV = Console.ReadLine() ?? "";

            Console.Write("Luong co ban: ");
            LuongCoBan = double.Parse(Console.ReadLine() ?? "0");
        }

        public virtual void Xuat()
        {
            Console.Write($"{MaNV} - {TenNV} - {LuongCoBan} - ");
        }

        public virtual double TinhLuong()
        {
            return LuongCoBan;
        }
    }
}