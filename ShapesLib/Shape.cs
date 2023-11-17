using System;
using System.Drawing;
using System.IO;

namespace ShapesLib
{
    public abstract class Shape
    {
        public string Name { get; set; }

        public Shape(string name)
        {
            Name = name;
        }
        public abstract double GetArea();
        public abstract double GetPerimeter();
        public double SideLengthCalculate(Point vertexOne, Point vertexTwo)
        {
            return Math.Sqrt(Math.Pow(vertexTwo.X - vertexOne.X, 2) + Math.Pow(vertexTwo.Y - vertexOne.Y, 2));
        }

        public override string ToString()
        {
            return $"Type: {Name}, Area: {GetArea()}; Perimeter: {GetPerimeter()}";
        } 
    }  
}
