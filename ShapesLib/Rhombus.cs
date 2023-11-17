using ShapesLib;
using System;
using System.Drawing;

    public class Rhombus:Shape
{
    private Point vertexA;
    private Point vertexB;
    private Point vertexC;
    private Point vertexD;
    public Rhombus(Point vA, Point vB, Point vC, Point vD):base ("Rhombus")
	{
        this.vertexA = vA;
        this.vertexB = vB;
        this.vertexC = vC;
        this.vertexD = vD;
	}
    public override double GetArea()
    {
        double diagonalAC = SideLengthCalculate(vertexA, vertexC);
        double diagonalBD = SideLengthCalculate(vertexB, vertexD);
        return (diagonalAC * diagonalBD) / 2;

    }
    public override double GetPerimeter()
    {
        double sideLength = SideLengthCalculate(vertexA, vertexB);
        return 4 * sideLength;
    }
}
