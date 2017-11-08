using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikko44
{
    abstract class Shape
    {
        public string Name { get; set; }
        public Shape(string name)
        {
            Name = name;
        }
        public abstract double Area();
        public abstract double Circumference();
    }
    class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle(string name, int radius) : base(name)
        {
            Radius = radius;
        }
        public override double Area()
        {
            double area = Math.PI * Radius * Radius;
            double inputvalue = Math.Round(area, 2);
            return inputvalue;
        }
        public override double Circumference()
        {
            double circumference = 2 * Math.PI * Radius;
            double inputvalue = Math.Round(circumference, 2);
            return inputvalue;
        }
        public override string ToString()
        {
            return "\n-------\n" + Name+" Radius: "+ Radius + " Area: " + Area() + " Circumference: " + Circumference();
        }
    }
    class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle(string name, int width, int height) : base(name)
        {
            Width = width;
            Height = height;
        }
        public override double Area()
        {
            double area = Width * Height;
            double inputvalue = Math.Round(area, 2);
            return inputvalue;
        }
        public override double Circumference()
        {
            double circumference = 2 * Width + 2 * Height;
            double inputvalue = Math.Round(circumference, 2);
            return inputvalue;
        }
        public override string ToString()
        {
            return "\n-------\n" + Name + " Width: " + Width+" Height: "+Height + " Area: " + Area() + " Circumference: " + Circumference();
        }
    }
}
