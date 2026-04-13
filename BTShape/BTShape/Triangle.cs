using System;
using System.Collections.Generic;
using System.Text;

namespace BTShape
{
    public class Triangle : Shape
    {
        private double a, b, c;

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap a: ");
            a = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Nhap b: ");
            b = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Nhap c: ");
            c = double.Parse(Console.ReadLine()!);
        }
        public override double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
