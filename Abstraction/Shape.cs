using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract public class Shape
    {
        abstract public void area();
    }

    public class Rectangle : Shape
    {
        private int length, width;
        private double result, PI=3.14;

        public Rectangle(int length,int width)
        {
            this.length = length;
            this.width = width;

        }

        public override void area() 
        {
            result = length * width;
        }

        public override string ToString()
        {
            return $"Area of Reactangele = {result} sq.";
        }

    }

    class Circle : Shape
    {
        int radius;
        double result, PI = 3.14;

        public Circle(int radius)
        {
            this.radius = radius;
        }
        public override void area()
        {
            result = PI*radius*radius;

        }
        public override string ToString()
        {
            return $"Area of Circle = {result} sq."; 
        }
    }
}
