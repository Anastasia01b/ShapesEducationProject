using System;
using System.Drawing;
using ShapesLib;

public class Square : Shape
{
    private Point vertexA; 
    private Point vertexB; 
    private Point vertexC;
    private Point vertexD;
	public Square(Point vA, Point vB, Point vC, Point vD): base("Square")
	{
        this.vertexA = vA;
        this.vertexB = vB;
        this.vertexC = vC;
        this.vertexD = vD;
	}
    public override double GetArea()
    {
        double sideLength = SideLengthCalculate(vertexA, vertexB);
        return sideLength * sideLength;

    }
    public override double GetPerimeter()
    {
        double sideLength = SideLengthCalculate(vertexA, vertexB);
        return 4 * sideLength;
    }
}
