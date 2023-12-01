using System.Drawing;
using System;
using ShapesLib;

public class Ellipse : ShapesUnusual
{
    private double axisSemiMajor;
    private double axisSemiMinor;
    private Point center;

    public Ellipse(Point center, double axisSemiMajor, double axisSemiMinor) : base("Ellipse", center)
    {
        this.center = center;
        this.axisSemiMajor = axisSemiMajor;
        this.axisSemiMinor = axisSemiMinor;
    }

    public override double GetArea()
    {
        return Math.Round(Math.PI  * axisSemiMinor * axisSemiMajor, 2);
    }

    public override double GetPerimeter()
    {
        double perimeter = 4*((Math.PI* axisSemiMajor* axisSemiMinor + Math.Pow(axisSemiMajor- axisSemiMinor, 2))/(axisSemiMajor + axisSemiMinor));
        return Math.Round(perimeter, 2);
    }

}

