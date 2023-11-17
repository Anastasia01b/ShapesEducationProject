using NUnit.Framework;
using ShapesLib;
using System.Drawing;
using System;

namespace ShapesLib.Tests
{
    [TestFixture]
    public class RhombusTests
    {
        [TestCase(-1, -2, -1, 2, 3, 2, 3, -2, "Rhombus")]
        [TestCase(-2, -2, -2, 1, 1, 1, 1, -2, "Rhombus")]
        [TestCase(-5, 3, -5, 6, -2, 6, -2, 3, "Rhombus")]
        public void TestRhombusConstructor(int xA, int yA, int xB, int yB, int xC, int yC, int xD, int yD, string expectedName)
        {
            Point vertexA = new Point(xA, yA);
            Point vertexB = new Point(xB, yB);
            Point vertexC = new Point(xC, yC);
            Point vertexD = new Point(xD, yD);

            Rhombus rhombus = new Rhombus(vertexA, vertexB, vertexC, vertexD);

            Assert.AreEqual(expectedName, rhombus.Name);
        }

        [TestCase(-1, -2, -1, 2, 3, 2, 3, -2, ExpectedResult = 16)]
        [TestCase(-2, -2, -2, 1, 1, 1, 1, -2, ExpectedResult = 9)]
        [TestCase(-5, 3, -5, 6, -2, 6, -2, 3, ExpectedResult = 9)]
        [TestCase(2, 4, 2, 6, 4, 6, 4, 4, ExpectedResult = 4)]
        [TestCase(5, 1, 5, 2, 6, 2, 6, 1, ExpectedResult = 1)]
         public double TestRhombusArea(int xA, int yA, int xB, int yB, int xC, int yC, int xD, int yD)
        {
            Point vertexA = new Point(xA, yA);
            Point vertexB = new Point(xB, yB);
            Point vertexC = new Point(xC, yC);
            Point vertexD = new Point(xD, yD);
            Rhombus rhombus = new Rhombus(vertexA, vertexB, vertexC, vertexD);

            return Math.Round(rhombus.GetArea(), 2);
        }

        [TestCase(-1, -2, -1, 2, 3, 2, 3, -2, ExpectedResult = 16)]
        [TestCase(-2, -2, -2, 1, 1, 1, 1, -2, ExpectedResult = 12)]
        [TestCase(-5, 3, -5, 6, -2, 6, -2, 3, ExpectedResult = 12)]
        [TestCase(2, 4, 2, 6, 4, 6, 4, 4, ExpectedResult = 8)]
        [TestCase(5, 1, 5, 2, 6, 2, 6, 1, ExpectedResult = 4)]
        public double TestRhombusPerimeter(int xA, int yA, int xB, int yB, int xC, int yC, int xD, int yD)
        {
            Point vertexA = new Point(xA, yA);
            Point vertexB = new Point(xB, yB);
            Point vertexC = new Point(xC, yC);
            Point vertexD = new Point(xD, yD);
            Rhombus rhombus = new Rhombus(vertexA, vertexB, vertexC, vertexD);

            return Math.Round(rhombus.GetPerimeter(), 2);
        }

        [TestCase(-1, -2, -1, 2, 3, 2, 3, -2, ExpectedResult = "Type: Rhombus, Area: 16; Perimeter: 16")]
        [TestCase(-2, -2, -2, 1, 1, 1, 1, -2, ExpectedResult = "Type: Rhombus, Area: 9; Perimeter: 12")]
        [TestCase(-5, 3, -5, 6, -2, 6, -2, 3, ExpectedResult = "Type: Rhombus, Area: 9; Perimeter: 12")]
        [TestCase(2, 4, 2, 6, 4, 6, 4, 4, ExpectedResult = "Type: Rhombus, Area: 4; Perimeter: 8")]
        [TestCase(5, 1, 5, 2, 6, 2, 6, 1, ExpectedResult = "Type: Rhombus, Area: 1; Perimeter: 4")]
        public string TestRhombusToString(int xA, int yA, int xB, int yB, int xC, int yC, int xD, int yD)
        {
            Point vertexA = new Point(xA, yA);
            Point vertexB = new Point(xB, yB);
            Point vertexC = new Point(xC, yC);
            Point vertexD = new Point(xD, yD);
            Rhombus rhombus = new Rhombus(vertexA, vertexB, vertexC, vertexD);

            return $"Type: Rhombus, Area: {Math.Round(rhombus.GetArea())}; Perimeter: {Math.Round(rhombus.GetPerimeter())}";
        }
    }
}

