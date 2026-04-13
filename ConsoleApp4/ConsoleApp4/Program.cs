using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    public class NhanVien
    {
        private string hoTen;
        private DateTime ngaySinh;
        private double luong;

        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public double Luong { get => luong; set => luong = value; }

        public NhanVien(string hoTen, DateTime ngaySinh)
        {
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
        }
        public NhanVien()
        {
            hoTen = "";
            ngaySinh = DateTime.Now;
            luong = 0;
        }

        public virtual void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            string hoTen = Console.ReadLine() ?? "";
            Console.Write("Nhap ngay sinh: ");
            DateTime ns;
            while (!DateTime.TryParse(Console.ReadLine(), out ns))
            {
                Console.WriteLine("Nhap lai ngay sinh:");
            }
            ngaySinh = ns;

        }
        public virtual double TinhLuong()
        {
            return 0;
        }

        public virtual void Xuat()
        {
            Console.Write($"Ho ten: {hoTen} ");
            Console.Write($", Ngay sinh: {ngaySinh} ");
            Console.Write($", Luong: {TinhLuong()}");
            Console.WriteLine();
        }
    }
    public class NVVanPhong : NhanVien
    {
        private int soNgayLam;
        public int SoNgayLam { get => soNgayLam; set => soNgayLam = value; }

        public NVVanPhong(string hoTen, DateTime ngaySinh, int soNgayLam) : base(hoTen, ngaySinh)
        {
            this.soNgayLam = soNgayLam;
        }

        public NVVanPhong() : base()
        {
            soNgayLam = 0;
        }
        public override double TinhLuong()
        {
            return soNgayLam * 100000;
        }
    }
    public class NVSanXuat : NhanVien
    {
        private double luongCB;
        private int soSP;

        public double LuongCoBan { get => luongCB; set => luongCB = value; }
        public int SoSP { get => soSP; set => soSP = value; }

        public NVSanXuat(string hoTen, DateTime ngaySinh, double luongCB, int soSP) : base(hoTen, ngaySinh)
        {
            this.luongCB = luongCB;
            this.soSP = soSP;
        }

        public NVSanXuat() : base()
        {
            luongCB = 0;
            soSP = 0;
        }
        public override double TinhLuong()
        {
            return luongCB + soSP * 5000;
        }
    }

    public class Program
    {
        static void NhapDS(List<NhanVien> dsNV, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhap nhan vien thu {i + 1}:");

                Console.Write("Chon loai (1:VP, 2:SX): ");
                int choice = int.Parse(Console.ReadLine() ?? "0");

                Console.Write("Nhap ho ten: ");
                string hoTen = Console.ReadLine() ?? "";

                Console.Write("Nhap ngay sinh: ");
                DateTime ngaySinh = DateTime.Parse(Console.ReadLine()!);

                if (choice == 1)
                {
                    Console.Write("Nhap so ngay lam: ");
                    int soNgayLam = int.Parse(Console.ReadLine()!);

                    dsNV.Add(new NVVanPhong(hoTen, ngaySinh, soNgayLam));
                }
                else if (choice == 2)
                {
                    Console.Write("Nhap luong co ban: ");
                    double luongCB = double.Parse(Console.ReadLine()!);

                    Console.Write("Nhap so san pham: ");
                    int soSP = int.Parse(Console.ReadLine()!);

                    dsNV.Add(new NVSanXuat(hoTen, ngaySinh, luongCB, soSP));
                }
            }
        }
        public static void InDS(List<NhanVien> dsNV)
        {
            foreach (NhanVien n in dsNV)
            {
                Console.WriteLine($"Ho ten: {n.HoTen}");
                Console.WriteLine($"Ngay sinh: {n.NgaySinh}");
                if (n is NVSanXuat nvsx)
                {
                    Console.WriteLine($"Luong can ban: {nvsx.LuongCoBan}");
                    Console.WriteLine($"So san pham: {nvsx.SoSP}");
                }
                if (n is NVVanPhong nvvp)
                {
                    Console.WriteLine($"So ngay lam: {nvvp.SoNgayLam}");
                }
                Console.WriteLine($"Tong luong: {n.TinhLuong()}");
            }
        }
        public static void Main(string[] args)
        {
            List<NhanVien> ds = new List<NhanVien>();

            Console.Write("Nhap so luong: ");
            int n = int.Parse(Console.ReadLine() ?? "0");

            NhapDS(ds, n);
            InDS(ds);

            
        }
    }
}