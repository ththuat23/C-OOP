using System;
using System.Collections.Generic;

namespace QLNV
{
    class Program
    {
        static void Main()
        {
            List<NhanVien> ds = new List<NhanVien>();

            Console.Write("Nhap so luong NV: ");
            int n = int.Parse(Console.ReadLine() ?? "0");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("---");
                Console.WriteLine("1. NV Van Phong | 2. NV San Xuat");
                int loai = int.Parse(Console.ReadLine() ?? "0");

                NhanVien nv;

                if (loai == 1)
                    nv = new NhanVienVanPhong();
                else
                    nv = new NhanVienSanXuat();

                nv.Nhap();
                ds.Add(nv);
            }

            // Xuất danh sách
            Console.WriteLine("\nDanh sach NV:");
            foreach (var nv in ds)
            {
                nv.Xuat();
            }

            // Tìm kiếm
            Console.Write("\nNhap ma can tim: ");
            string ma = Console.ReadLine() ?? "";

            var kq = ds.Find(nv => nv.MaNV == ma);
            if (kq != null)
                kq.Xuat();
            else
                Console.WriteLine("Khong tim thay");

            // Sắp xếp
            ds.Sort((a, b) => b.TinhLuong().CompareTo(a.TinhLuong()));

            Console.WriteLine("\nSau khi sap xep:");
            foreach (var nv in ds)
            {
                nv.Xuat();
            }

            // Xóa
            Console.Write("\nNhap ma can xoa: ");
            string maXoa = Console.ReadLine() ?? "";

            ds.RemoveAll(nv => nv.MaNV == maXoa);

            Console.WriteLine("\nSau khi xoa:");
            foreach (var nv in ds)
            {
                nv.Xuat();
            }
        }
    }
}