using System;
using System.Drawing;
using System.IO;
using ShapesLib;

public class Triangle : Shape
{
	protected Point vertexA { get; set; }
    protected Point vertexB { get; set; }
    protected Point vertexC { get; set; }
    public Triangle( Point vA, Point vB, Point vC) : base ("Triangle")
	{
        this.vertexA = vA;
        this.vertexB = vB;
        this.vertexC = vC;

	}
      public override double GetArea()
    {
        return Math.Abs(0.5 * ((vertexA.X * (vertexB.Y - vertexC.Y) + vertexB.X * (vertexC.Y - vertexA.Y) + vertexC.X * (vertexA.Y - vertexB.Y))));
    }
    
    public override double GetPerimeter()
    {
        return SideLengthCalculate(vertexA, vertexB) + SideLengthCalculate(vertexB, vertexC) + SideLengthCalculate(vertexC, vertexA);
    }
}
