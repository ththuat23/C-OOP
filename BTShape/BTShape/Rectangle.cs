using System;
using System.Collections.Generic;
using System.Text;

namespace BTShape
{
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap width: ");
            width = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Nhap height: ");
            height = double.Parse(Console.ReadLine()!);
        }
        public override double Area()
        {
            return width * height;
        }
    }
}
