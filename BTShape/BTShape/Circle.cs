using System;
using System.Collections.Generic;
using System.Text;

namespace BTShape
{
    public class Circle : Shape
    {
        private double radius;

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap ban kinh: ");
            radius = double.Parse(Console.ReadLine()!);
        }
        public override double Area()
        {
            return Math.PI * radius * radius;
        }
    }
}
