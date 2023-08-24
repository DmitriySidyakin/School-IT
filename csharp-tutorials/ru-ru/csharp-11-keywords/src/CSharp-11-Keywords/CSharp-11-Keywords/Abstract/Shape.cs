using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_11_Keywords.Abstract
{
    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Circle : Shape
    {
        private int _r;

        public Circle(int radius) => _r = radius;

        public override double GetArea() => Math.PI * _r * _r;

        static void Main()
        {
            var cir = new Circle(2);
            Console.WriteLine($"Area of the circle = {cir.GetArea()}");
        }
    }
}
