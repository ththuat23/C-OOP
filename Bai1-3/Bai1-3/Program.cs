/*
Một loại vi trùng cứ sau mỗi giờ lại nhân đôi. Hỏi ban đầu có n con vi trùng thì sau h giờ số lượng là bao nhiêu?

Input:
- Số lượng vi trùng ban đầu (con)
- Khoảng thời gian (giờ).

Output: Số lượng vi trùng sau khoảng thời gian đã cho.
*/
using System;

namespace ViTrung
{
    class Program
    {
        static void Main()
        {
            long n;
            int h;

            // Input
            Console.Write("Nhap so vi trung ban dau: ");
            n = long.Parse(Console.ReadLine());

            Console.Write("Nhap so gio: ");
            h = int.Parse(Console.ReadLine());

            // Process
            for (int i = 0; i < h; i++)
            {
                n = n * 2;
            }

            // Output
            Console.WriteLine("So vi trung sau {0} gio la: {1}", h, n);
        }
    }
}