using System;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;

namespace LiskovSubstitutionalPrinciple
{

    class Rectangle
    {
        public virtual int Width { get;  set; }
        public virtual int Heigth { get;  set; }

        public Rectangle()
        {
            
        }
        public Rectangle(int width, int heigth)
        {
            Width = width;
            Heigth = heigth;
        }

        public override string ToString()
        {
            return $"{nameof(Width)} : {Width}, {nameof(Heigth)} : {Heigth}";
        }
    }

    class Square : Rectangle
    {
        public override int Width
        {
            set { base.Width = base.Heigth = value; }
        }
        
        public override int Heigth
        {
            set { base.Heigth = base.Width = value; }
        }
    }
    class Program
    {
        public static int Area(Rectangle r) => r.Width * r.Heigth;
        static void Main(string[] args)
        {
            var rc = new Rectangle(100,30);
            
            Console.WriteLine($"{rc} has area of {Area(rc)}");

            Rectangle sq = new Square();
            sq.Width = 4;
            
            Console.WriteLine($"{sq} has area of {Area(sq)}");
        }
    }
}