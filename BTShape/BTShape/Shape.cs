using System;
using System.Collections.Generic;
using System.Text;

namespace BTShape
{
    public class Shape
    {
        private String name = "";
        public string Name { get => name; set => name = value; }
        public Shape() { }
        public Shape(String name)
        {
            this.name = name;
        }
        public virtual void Nhap() 
        {
            Console.Write("Nhap ten hinh: ");
            name = Console.ReadLine() ??"";
        }
        public virtual double Area() 
        {
            return 0;
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Ten: " + name + ", Dien tich: " + Area());
        }
    }   
}
