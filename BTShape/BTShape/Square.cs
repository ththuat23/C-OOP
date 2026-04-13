using System;
using System.Collections.Generic;
using System.Text;

namespace BTShape
{
    public class Square : Rectangle
    {
        private double side;

        public override void Nhap()
        {
            Console.WriteLine("Nhap ten hinh: ");
            Name = Console.ReadLine()??"";

            Console.WriteLine("Nhap canh: ");
            side = double.Parse(Console.ReadLine()!);
        }
        public override double Area()
        {
            return side * side;
        }
    }
}
