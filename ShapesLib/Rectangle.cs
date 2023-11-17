using System;
using System.Drawing;
using ShapesLib;

public class Rectangle:Shape
{
    private Point vertexA;
    private Point vertexB;
    private Point vertexC;
    private Point vertexD;
    public Rectangle(Point vA, Point vB, Point vC, Point vD): base("Rectangle")
    {
        this.vertexA = vA;
        this.vertexB = vB;
        this.vertexC = vC;
        this.vertexD = vD;
    }
    public override double GetArea()
    {
        CalculateSides(out double sideLength, out double sideWidth);
        return sideLength * sideWidth;
    }
    public override double GetPerimeter()
    {
        CalculateSides(out double sideLength, out double sideWidth);
        return (sideLength + sideWidth) * 2;
    }
    private void CalculateSides(out double sideLength, out double sideWidth)
    {
        sideLength = SideLengthCalculate(vertexA, vertexB);
        sideWidth = SideLengthCalculate(vertexB, vertexC);
    }

}

