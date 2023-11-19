using System;
using System.Drawing;
using ShapesLib;

public class EquilateralTriangle :Shape
{
    private Point vertexA;
    private Point vertexB;
    private Point vertexC;
    public EquilateralTriangle(Point vA, Point vB, Point vC) : base("EquilateralTriangle")
	{
        this.vertexA = vA;
        this.vertexB = vB;
        this.vertexC = vC;
        
	}
    public override double GetArea()
    {
        double sideLength = SideLengthCalculate(vertexA, vertexB);
        return (Math.Sqrt(3)/4) * Math.Pow(sideLength, 2);
    }
    public override double GetPerimeter()
    {
        double sideLength = SideLengthCalculate(vertexA, vertexB);
        return 3 * sideLength;
    }
}
