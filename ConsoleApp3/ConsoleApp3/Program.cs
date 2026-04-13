using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    public class Xe
    {
        private String bienSo;
        private int namSX;
        private double gia;

        public string BienSo { get => bienSo; set => bienSo = value; }
        public int NamSX { get => namSX; set => namSX = value; }
        public double Gia { get => gia; set => gia = value; }

        public Xe(string bienSo, int namSX, double gia)
        {
            this.bienSo = bienSo;
            this.namSX = namSX;
            this.gia = gia;
        }
        public Xe()
        {
            this.bienSo = "";
            this.namSX = 0;
            this.gia = 0;
        }
        public virtual void Nhap()
        {
            Console.Write("Nhap bien so: ");
            bienSo = Console.ReadLine() ?? "";
            Console.Write("Nhap nam san xuat: ");
            //namSX = int.Parse(Console.ReadLine());
            //kiem tra kieu du lieu nhap
            while (!int.TryParse(Console.ReadLine(), out namSX))
            {
                Console.WriteLine("Du lieu khong hop le! ");
                Console.WriteLine("Nhap lai nam san xuat: ");
            }
            Console.WriteLine("Nhap gia: ");
            //gia = double.Parse(Console.ReadLine());
            while (!double.TryParse(Console.ReadLine(), out gia))
            {
                Console.WriteLine("Du lieu khong hop le!");
                Console.WriteLine("Nhap lai gia: ");
            }
        }
        public virtual void Xuat()
        {
            Console.WriteLine($"Bien so: {bienSo} ");
            Console.WriteLine($"Nam san xuat: {namSX} ");
            Console.WriteLine($"Gia: {gia} ");
        }
    }
    public class XeCon : Xe
    {
        private int soChoNgoi;
        private string loaiXe;
        public int SoChoNgoi { get => soChoNgoi; set => soChoNgoi = value; }
        public string LoaiXe { get => loaiXe; set => loaiXe = value; }

        public XeCon(string bienSo, int namSX, double gia, int soChoNgoi, string loaiXe) : base(bienSo, namSX, gia)
        {
            this.soChoNgoi = soChoNgoi;
            this.loaiXe = loaiXe;
        }
        public XeCon() : base()
        {
            this.soChoNgoi = 0;
            this.loaiXe = "";
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so cho ngoi: ");
            while (!int.TryParse(Console.ReadLine(), out soChoNgoi))
            {
                Console.WriteLine("Du lieu khong hop le!");
                Console.WriteLine("Nhap lai so cho ngoi: ");
            }
            Console.WriteLine("Nhap loai xe (seda/SUV/ban tai)");
            loaiXe = Console.ReadLine() ?? "";
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"So cho ngoi: {soChoNgoi} ");
            Console.WriteLine($"Loai xe: {loaiXe} ");
        }
        
    }
    internal class Program
    {
        static void NhapDS(List<XeCon> dsXe, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap thong tin xe con thu {i + 1}: ");
                XeCon newXe = new XeCon();
                newXe.Nhap();
                dsXe.Add(newXe);
            }
        }
        static XeCon timMin(List<XeCon> dsXe)
        {
            double min = double.MaxValue;
            XeCon xeMin = new XeCon();
            for (int i = 0; i < dsXe.Count; i++)
            {
                if (dsXe[i].Gia < min)
                {
                    min = dsXe[i].Gia;
                    xeMin = dsXe[i];
                }
            }
            return xeMin;
        }
        static XeCon timMax(List<XeCon> dsXe)
        {
            double max = double.MinValue;
            XeCon xeMax = new XeCon();
            for (int i = 0; i < dsXe.Count; i++)
            {
                if (dsXe[i].Gia > max)
                {
                    max = dsXe[i].Gia;
                    xeMax = dsXe[i];
                }
            }
            return xeMax;
        }
        static List<XeCon> TimBS(List<XeCon> dsXe, int n)
        {
            Console.WriteLine("Nhap 2 so dau: ");
            string tinh = Console.ReadLine() ?? "";
            List<XeCon> xeThuocTinh = new List<XeCon>();
            foreach (XeCon xe in dsXe)
            {
                if (!string.IsNullOrEmpty(tinh) && xe.BienSo.StartsWith(tinh))
                {
                    xeThuocTinh.Add(xe);
                }
            }
            return xeThuocTinh;
        }
        static void Main(string[] args)
        {
            List<XeCon> dsXe = new List<XeCon>();
            Console.WriteLine("Nhap so luong xe: ");
            int n = int.Parse(Console.ReadLine()!);
            NhapDS(dsXe, n);

            Console.WriteLine("Xe co gia tri nho nhat la: ");
            XeCon xeMin = timMin(dsXe);
            xeMin.Xuat();

            Console.WriteLine("Xe co gia tri lon nhat la: ");
            XeCon xeMax = timMax(dsXe);
            xeMax.Xuat();

            TimBS(dsXe, n);
            
            dsXe.Sort((a, b) => a.Gia.CompareTo(b.Gia));
        }
    }
}