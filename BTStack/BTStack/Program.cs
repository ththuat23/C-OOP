using System;
using System.Collections.Generic;
using System.Text;

namespace BTStack
{
    class Program
    {
        // Phân tích thừa số
        static void PhanTich(int n)
        {
            PrimeStack s = new PrimeStack(100);

            int temp = n;
            for (int i = 2; i <= temp; i++)
            {
                while (temp % i == 0)
                {
                    s.Push(i);
                    temp /= i;
                }
            }

            Console.Write("Phan tich " + n + " = ");
            s.Print();
        }

        // Đổi sang HEX
        static void DoiHex(int n)
        {
            HexaStack s = new HexaStack(100);

            int temp = n;
            while (temp > 0)
            {
                s.Push(temp % 16);
                temp /= 16;
            }

            Console.Write("Hexa cua " + n + " = ");
            s.Print();
        }

        static void Main()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine()!);

            PhanTich(n);
            DoiHex(n);
        }
    }
}
