//Viết chương trình C# thực hiện các công việc sau (mỗi chức năng xây dựng thành một hàm):
//a) Nhập một mảng n số nguyên từ bàn phím.
//b) In các phần tử của mảng lên màn hình.
//c) Trả về phần tử lớn nhất của mảng.
//d) Trả về kiểu boolean kiểm tra mảng đã được sắp xếp tăng dần chưa.
//e) Sắp xếp mảng theo thứ tự tăng dần.
//f) Tách mảng thành 2 mảng con: một mảng chứa các phần tử chẵn, mảng còn lại chứa các phần tử lẻ.
using System;

namespace BaiTapMang
{
    class Program
    {
        // a) Nhập mảng
        static void NhapMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu a[" + i + "] = ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        // b) Xuất mảng
        static void XuatMang(int[] a, int n)
        {
            Console.WriteLine("Cac phan tu trong mang:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        // c) Tìm phần tử lớn nhất
        static int Max(int[] a, int n)
        {
            int max = a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }
            return max;
        }

        // d) Kiểm tra mảng tăng dần
        static bool KiemTraTangDan(int[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                if (a[i] > a[i + 1])
                    return false;
            }
            return true;
        }

        // e) Sắp xếp tăng dần
        static void SapXepTangDan(int[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }

        // f) Tách mảng chẵn lẻ
        static void TachChanLe(int[] a, int n)
        {
            Console.Write("Mang chan: ");
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                    Console.Write(a[i] + " ");
            }

            Console.WriteLine();

            Console.Write("Mang le: ");
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 != 0)
                    Console.Write(a[i] + " ");
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so phan tu: ");
            n = int.Parse(Console.ReadLine());

            int[] a = new int[n];

            NhapMang(a, n);

            XuatMang(a, n);

            Console.WriteLine("Phan tu lon nhat: " + Max(a, n));

            if (KiemTraTangDan(a, n))
                Console.WriteLine("Mang da sap xep tang dan");
            else
                Console.WriteLine("Mang chua sap xep tang dan");

            SapXepTangDan(a, n);
            Console.WriteLine("Mang sau khi sap xep:");
            XuatMang(a, n);

            TachChanLe(a, n);
        }
    }
}