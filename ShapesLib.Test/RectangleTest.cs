using NUnit.Framework;
using ShapesLib;
using System.Drawing;

namespace ShapesLib.Tests
{
    [TestFixture]
    public class RectangleTests
    {
        [TestCase(-6 , 4, -6, 6, -1, 6, -1, 4, "Rectangle")]
        [TestCase(1, 2, 1, 4, 5, 4, 5, 2, "Rectangle")]
        [TestCase(-3, -1, -3, 3, 4, 3, 4, -1, "Rectangle")]
        public void TestRectangleConstructor(int xA, int yA, int xB, int yB, int xC, int yC, int xD, int yD, string expectedName)
        {
            Point vertexA = new Point(xA, yA);
            Point vertexB = new Point(xB, yB);
            Point vertexC = new Point(xC, yC);
            Point vertexD = new Point(xD, yD);

            Rectangle rectangle = new Rectangle(vertexA, vertexB, vertexC, vertexD);

            Assert.AreEqual(expectedName, rectangle.Name);
        }

        [TestCase(-6, 4, -6, 6, -1, 6, -1, 4, ExpectedResult =10)]
        [TestCase(1, 2, 1, 4, 5, 4, 5, 2, ExpectedResult = 8)]
        [TestCase(-3, -1, -3, 3, 4, 3, 4, -1, ExpectedResult = 28)]
        [TestCase(-2, 1, -2, 2, 1, 2, 1, 1, ExpectedResult = 3)]
        [TestCase(-4, -2, -4, 1, 2, 1, 2, -2, ExpectedResult = 18)]
        public double TestRectangleArea(int xA, int yA, int xB, int yB, int xC, int yC, int xD, int yD)
        {
            Point vertexA = new Point(xA, yA);
            Point vertexB = new Point(xB, yB);
            Point vertexC = new Point(xC, yC);
            Point vertexD = new Point(xD, yD);
            Rectangle rectangle = new Rectangle(vertexA, vertexB, vertexC, vertexD);

            return rectangle.GetArea( );
        }

        [TestCase(-6, 4, -6, 6, -1, 6, -1, 4, ExpectedResult = 14)]
        [TestCase(1, 2, 1, 4, 5, 4, 5, 2, ExpectedResult = 12)]
        [TestCase(-3, -1, -3, 3, 4, 3, 4, -1, ExpectedResult = 22)]
        [TestCase(-2, 1, -2, 2, 1, 2, 1, 1, ExpectedResult = 8)]
        [TestCase(-4, -2, -4, 1, 2, 1, 2, -2, ExpectedResult = 18)]
        public double TestRectanglePerimeter(int xA, int yA, int xB, int yB, int xC, int yC, int xD, int yD)
        {
            Point vertexA = new Point(xA, yA);
            Point vertexB = new Point(xB, yB);
            Point vertexC = new Point(xC, yC);
            Point vertexD = new Point(xD, yD);
            Rectangle rectangle = new Rectangle(vertexA, vertexB, vertexC, vertexD);

            return rectangle.GetPerimeter();
        }

        [TestCase(-6, 4, -6, 6, -1, 6, -1, 4, ExpectedResult = "Type: Rectangle, Area: 10; Perimeter: 14")]
        [TestCase(1, 2, 1, 4, 5, 4, 5, 2, ExpectedResult = "Type: Rectangle, Area: 8; Perimeter: 12")]
        [TestCase(-3, -1, -3, 3, 4, 3, 4, -1, ExpectedResult = "Type: Rectangle, Area: 28; Perimeter: 22")]
        [TestCase(-2, 1, -2, 2, 1, 2, 1, 1, ExpectedResult = "Type: Rectangle, Area: 3; Perimeter: 8")]
        [TestCase(-4, -2, -4, 1, 2, 1, 2, -2, ExpectedResult = "Type: Rectangle, Area: 18; Perimeter: 18")]
        public string TestRectangleToString(int xA, int yA, int xB, int yB, int xC, int yC, int xD, int yD)
        {
            Point vertexA = new Point(xA, yA);
            Point vertexB = new Point(xB, yB);
            Point vertexC = new Point(xC, yC);
            Point vertexD = new Point(xD, yD);
            Rectangle rectangle = new Rectangle(vertexA, vertexB, vertexC, vertexD);

            return rectangle.ToString();
        }
    }
}

