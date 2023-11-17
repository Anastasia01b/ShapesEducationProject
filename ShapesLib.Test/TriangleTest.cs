using NUnit.Framework;
using ShapesLib;
using System;
using System.Drawing;

namespace ShapesLib.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        [TestCase(0, 0, 0, 1, 1, 0, "Triangle")]
        [TestCase(1, 2, 3, 4, 5, 6, "Triangle")]
        public void TestTriangleConstructor(int xA, int yA, int xB, int yB, int xC, int yC, string expectedName)
        {
            Point vertexA = new Point(xA, yA);
            Point vertexB = new Point(xB, yB);
            Point vertexC = new Point(xC, yC);

            Triangle triangle = new Triangle(vertexA, vertexB, vertexC);

            Assert.AreEqual(expectedName, triangle.Name);
        }

        [TestCase(0, 0, 0, 1, 1, 0, ExpectedResult = 0.5)]
        [TestCase(-1, 2, -2, 4, 3, -1, ExpectedResult = 2.5)]
        [TestCase(1, 2, 3, 4, 5, 6, ExpectedResult = 0)]
        [TestCase(-4, 0, -1, 4, -1, 0, ExpectedResult = 6)]
        [TestCase(-7, 1, -5, 5, -1, 4, ExpectedResult = 9)]
        public double TestTriangleArea(int xA, int yA, int xB, int yB, int xC, int yC)
        {
            Point vertexA = new Point(xA, yA);
            Point vertexB = new Point(xB, yB);
            Point vertexC = new Point(xC, yC);
            Triangle triangle = new Triangle(vertexA, vertexB, vertexC);

            return Math.Round(triangle.GetArea(), 2);
        }

        [TestCase(0, 0, 0, 1, 1, 0, ExpectedResult = 3.41)]
        [TestCase(-4, 0, -1, 4, -1, 0, ExpectedResult = 12)]
        [TestCase(-7, 1, -5, 5, -1, 4, ExpectedResult = 15.30)]
        [TestCase(-3, -2, 1, 3, 1, -1, ExpectedResult = 14.53)]

        public double TestTrianglePerimeter(int xA, int yA, int xB, int yB, int xC, int yC)
        {
            Point vertexA = new Point(xA, yA);
            Point vertexB = new Point(xB, yB);
            Point vertexC = new Point(xC, yC);
            Triangle triangle = new Triangle(vertexA, vertexB, vertexC);

            return Math.Round (triangle.GetPerimeter(), 2);
        }

        [TestCase(0, 0, 0, 1, 1, 0, ExpectedResult = "Type: Triangle, Area: 0,5; Perimeter: 3,414213562373095")]
        [TestCase(1, 2, 3, 4, 5, 6, ExpectedResult = "Type: Triangle, Area: 0; Perimeter: 11,313708498984761")] 
        public string TestTriangleToString(int xA, int yA, int xB, int yB, int xC, int yC)
        {
            Point vertexA = new Point(xA, yA);
            Point vertexB = new Point(xB, yB);
            Point vertexC = new Point(xC, yC);
            Triangle triangle = new Triangle(vertexA, vertexB, vertexC);

            return triangle.ToString();
        }
    }
}
