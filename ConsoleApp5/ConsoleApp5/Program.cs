using System;

namespace ConsoleApp5
{
    public class HinhVe
    {
        public virtual double TinhDienTich()
        {
            return 0;
        }
        public virtual void Nhap() { }
        public virtual void Xuat()
        {
            Console.WriteLine("Dien tich: " + TinhDienTich());
        }
    }
    public class HinhChuNhat : HinhVe
    {
        private double chieuDai;
        private double chieuRong;
        public double ChieuDai { get => chieuDai; set => chieuDai = value; }
        public double ChieuRong { get => chieuRong; set => chieuRong = value; }
        public override void Nhap()
        {
            Console.Write("Nhap chieu dai: ");
            while (!double.TryParse(Console.ReadLine(), out chieuDai))
            {
                Console.WriteLine("Nhap lai chieu dai:");
            }
            Console.Write("Nhap chieu rong: ");
            while (!double.TryParse(Console.ReadLine(), out chieuRong))
            {
                Console.WriteLine("Nhap lai chieu rong:");
            }
        }
        public override double TinhDienTich()
        {
            return chieuDai * chieuRong;
        }
    }
    public class HinhVuong : HinhChuNhat
    {
        public override void Nhap()
        {
            Console.Write("Nhap canh: ");
            double canh;
            while (!double.TryParse(Console.ReadLine(), out canh))
            {
                Console.WriteLine("Nhap lai canh:");
            }
            ChieuDai = canh;
            ChieuRong = canh;
        }
    }
    public class HinhTron : HinhVe
    {
        private double banKinh;
        public double BanKinh { get => banKinh; set => banKinh = value; }
        public override void Nhap()
        {
            Console.Write("Nhap ban kinh: ");
            while (!double.TryParse(Console.ReadLine(), out banKinh))
            {
                Console.WriteLine("Nhap lai ban kinh:");
            }
        }
        public override double TinhDienTich()
        {
            return Math.PI * banKinh * banKinh;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chon hinh: ");
            Console.WriteLine("1. Hinh chu nhat");
            Console.WriteLine("2. Hinh vuong");
            Console.WriteLine("3. Hinh tron");

            int chon = int.Parse(Console.ReadLine() ?? "0");
            HinhVe h = null;

            if (chon == 1)
            {
                h = new HinhChuNhat();

            }
            else if (chon == 2)
            {
                h = new HinhVuong();
            }
            else if (chon == 3)
            {
                h = new HinhTron();
            }
            if (h != null)
            {
                h.Nhap();
                h.Xuat();
            }
        }
    }
}