using System;

namespace ConsoleApp6
{
    public class Printer
    {
        private string hangSX = "";
        private double gia;

        public string HangSX { get => hangSX; set => hangSX = value; }
        public double Gia { get => gia; set => gia = value; }

        public Printer() { }
        public Printer(string hangSX, double gia)
        {
            this.hangSX = hangSX;
            this.gia = gia;
        }
        public virtual void Nhap()
        {
            Console.WriteLine("Nhap hang san xuat: ");
            hangSX = Console.ReadLine()??"";

            Console.WriteLine("Nhap gia: ");
            while (!double.TryParse(Console.ReadLine(), out gia))
            {
                Console.WriteLine("Nhap lai gia:");
            }
        }
        public virtual void Xuat()
        {
            Console.WriteLine($"Hang san xuat: {hangSX}, Gia: {gia}");
        }
    }
    public class LaserPrinter : Printer
    {
        private string doPhanGiai = "";
        public string DoPhanGiai { get => doPhanGiai; set => doPhanGiai = value; }
        public LaserPrinter() : base() { }

        public LaserPrinter(string hangSX, double gia, string doPhanGiai) : base(hangSX, gia)
        {
            this.doPhanGiai = DoPhanGiai;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap do phan giai: ");
            doPhanGiai = Console.ReadLine() ?? "";
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Do phan giai: {doPhanGiai}");
        }
    }

    class Program
    {
        static void NhapDS(List<LaserPrinter> ds, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nNhap may in thu " + (i + 1));
                LaserPrinter p = new LaserPrinter();
                p.Nhap();
                ds.Add(p);
            }
        }
        static void XuatDS(List<LaserPrinter> ds)
        {
            Console.WriteLine("\nDanh sach may in:");
            foreach (LaserPrinter p in ds)
                p.Xuat();
        }
        static LaserPrinter TimMin(List<LaserPrinter> ds)
        {
            LaserPrinter min = ds[0];
            for (int i = 1; i < ds.Count; i++)
            {
                if (ds[i].Gia < min.Gia)
                    min = ds[i];
            }
            return min;
        }
        static LaserPrinter TimMax(List<LaserPrinter> ds)
        {
            LaserPrinter max = ds[0];
            for (int i = 1; i < ds.Count; i++)
            {
                if (ds[i].Gia > max.Gia)
                    max = ds[i];
            }
            return max;
        }
        static void LocTheoHang(List<LaserPrinter> ds)
        {
            Console.Write("\nNhap hang can tim: ");
            string hang = Console.ReadLine()??"";

            Console.WriteLine("Ket qua:");
            foreach (LaserPrinter p in ds)
            {
                if (p.HangSX.StartsWith(hang))
                    p.Xuat();
            }
        }
        static void SapXep(List<LaserPrinter> ds)
        {
            ds.Sort((a, b) => a.Gia.CompareTo(b.Gia));
        }
        static void Main()
        {
            List<LaserPrinter> ds = new List<LaserPrinter>();

            Console.Write("Nhap so luong: ");
            int n = int.Parse(Console.ReadLine()!);

            NhapDS(ds, n);
            XuatDS(ds);

            Console.WriteLine("\nMay gia thap nhat:");
            TimMin(ds).Xuat();

            Console.WriteLine("May gia cao nhat:");
            TimMax(ds).Xuat();

            LocTheoHang(ds);

            SapXep(ds);
            Console.WriteLine("\nSau khi sap xep:");
            XuatDS(ds);
        }
    }
}