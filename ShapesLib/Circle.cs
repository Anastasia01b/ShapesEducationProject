using System.Drawing;
using System;
using ShapesLib;

public class Circle : ShapesUnusual
{
    private double radius;

    public Circle(Point center, double radius) : base("Circle", center)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.Round(Math.PI * radius * radius, 2);
    }

    public override double GetPerimeter()
    {
        return Math.Round(2 * Math.PI * radius, 2);
    }
}