using BTShape;
using System.Collections.Generic;

class Program
{
    static void NhapDS(List<Shape> ds, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nChon hinh (1: HCN, 2: Vuong, 3: Tron, 4: Tam giac): ");
            int chon = int.Parse(Console.ReadLine()!);
            Shape? h = null;

            if (chon == 1) h = new Rectangle();
            else if (chon == 2) h = new Square();
            else if (chon == 3) h = new Circle();
            else if (chon == 4) h = new Triangle();

            if (h != null)
            {
                h.Nhap();
                ds.Add(h);
            }
        }
    }

    static void XuatDS(List<Shape> ds)
    {
        foreach (Shape h in ds)
            h.Xuat();
    }

    static Shape TimMax(List<Shape> ds)
    {
        Shape max = ds[0];
        foreach (Shape h in ds)
        {
            if (h.Area() > max.Area())
                max = h;
        }
        return max;
    }
    static void SapXepGiam(List<Shape> ds)
    {
        ds.Sort((a,b) => b.Area().CompareTo(a.Area()));
    }

    static void Main(string[] args)
    {
        List<Shape> ds = new List<Shape>();
        Console.WriteLine("Nhap n: ");
        int n = int.Parse(Console.ReadLine()!);
        NhapDS(ds, n);
        Console.WriteLine("\nDanh sach: ");
        XuatDS(ds);

        Console.WriteLine("\nHinh co dien tich lon nhat: ");
        TimMax(ds).Xuat();
        SapXepGiam(ds);
        Console.WriteLine("\nSau khi sap xep giam: ");
        XuatDS(ds);
    }
}
