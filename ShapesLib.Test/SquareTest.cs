using NUnit.Framework;
using ShapesLib;
using System.Drawing;

namespace ShapesLib.Tests
{
    [TestFixture]
    public class SquareTests
    {
        [TestCase(-1, -2, -1, 2, 3, 2, 3, -2, "Square")]
        [TestCase(-2, -2, -2, 1, 1, 1, 1, -2, "Square")]
        [TestCase(-5, 3, -5, 6, -2, 6, -2, 3 , "Square")]
        public void TestSquareConstructor(int xA, int yA, int xB, int yB, int xC, int yC,int xD, int yD, string expectedName)
        {
            Point vertexA = new Point(xA, yA);
            Point vertexB = new Point(xB, yB);
            Point vertexC = new Point(xC, yC);
            Point vertexD = new Point(xD, yD);
 
            Square square = new Square(vertexA, vertexB, vertexC, vertexD);

            Assert.AreEqual(expectedName, square.Name);
        }

        [TestCase(-1, -2, -1, 2, 3, 2, 3, -2, ExpectedResult = 16)]
        [TestCase(-2, -2, -2, 1, 1, 1, 1, -2, ExpectedResult = 9)]
        [TestCase(-5, 3, -5, 6, -2, 6, -2, 3, ExpectedResult = 9)]
        [TestCase(2, 4, 2, 6, 4, 6, 4, 4, ExpectedResult = 4)]
        [TestCase(5, 1, 5, 2, 6, 2, 6, 1, ExpectedResult = 1)]
        public double TestSquareArea(int xA, int yA, int xB, int yB, int xC, int yC, int xD, int yD)
        {
            Point vertexA = new Point(xA, yA);
            Point vertexB = new Point(xB, yB);
            Point vertexC = new Point(xC, yC);
            Point vertexD = new Point(xD, yD);
            Square square = new Square(vertexA, vertexB, vertexC, vertexD);

            return square.GetArea();
        }

        [TestCase(-1, -2, -1, 2, 3, 2, 3, -2, ExpectedResult = 16)]
        [TestCase(-2, -2, -2, 1, 1, 1, 1, -2, ExpectedResult = 12)]
        [TestCase(-5, 3, -5, 6, -2, 6, -2, 3, ExpectedResult = 12)]
        [TestCase(2, 4, 2, 6, 4, 6, 4, 4, ExpectedResult = 8)]
        [TestCase(5, 1, 5, 2, 6, 2, 6, 1, ExpectedResult = 4)]
        public double TestSquarePerimeter(int xA, int yA, int xB, int yB, int xC, int yC, int xD, int yD)
        {
            Point vertexA = new Point(xA, yA);
            Point vertexB = new Point(xB, yB);
            Point vertexC = new Point(xC, yC);
            Point vertexD = new Point(xD, yD);
            Square square = new Square(vertexA, vertexB, vertexC, vertexD);

            return square.GetPerimeter();
        }

        [TestCase(-1, -2, -1, 2, 3, 2, 3, -2, ExpectedResult = "Type: Square, Area: 16; Perimeter: 16")]
        [TestCase(-2, -2, -2, 1, 1, 1, 1, -2, ExpectedResult = "Type: Square, Area: 9; Perimeter: 12")]
        [TestCase(-5, 3, -5, 6, -2, 6, -2, 3, ExpectedResult = "Type: Square, Area: 9; Perimeter: 12")]
        [TestCase(2, 4, 2, 6, 4, 6, 4, 4, ExpectedResult = "Type: Square, Area: 4; Perimeter: 8")]
        [TestCase(5, 1, 5, 2, 6, 2, 6, 1, ExpectedResult = "Type: Square, Area: 1; Perimeter: 4")] 
        public string TestSquareToString(int xA, int yA, int xB, int yB, int xC, int yC, int xD, int yD)
        {
            Point vertexA = new Point(xA, yA);
            Point vertexB = new Point(xB, yB);
            Point vertexC = new Point(xC, yC);
            Point vertexD = new Point(xD, yD);
            Square square = new Square(vertexA, vertexB, vertexC, vertexD);

            return square.ToString();
        }
    }
}
