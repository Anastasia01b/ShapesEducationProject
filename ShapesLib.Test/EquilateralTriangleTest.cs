using NUnit.Framework;
using ShapesLib;
using System;
using System.Drawing;

namespace ShapesLib.Tests
{
    [TestFixture]
    public class EquilateralTriangleTests
    {
        [TestCase(0, 0, 1, 0, 0.5, 0.866, "EquilateralTriangle")]
        [TestCase(1, 2, 3, 4, 5, 6, "EquilateralTriangle")]
        [TestCase(6, 0, 7, 0, 6.5, 0.866, "EquilateralTriangle")]
        public void TestEquilateralTriangleConstructor(double xA, double yA, double xB, double yB, double xC, double yC, string expectedName)
        {
            Point vertexA = new Point((int)xA, (int)yA);
            Point vertexB = new Point((int)xB, (int)yB);
            Point vertexC = new Point((int)xC, (int)yC);

            EquilateralTriangle equilateralTriangle = new EquilateralTriangle(vertexA, vertexB, vertexC);

            Assert.AreEqual(expectedName, equilateralTriangle.Name);
        }

        [TestCase(0, 0, 1, 0, 0.5, 0.866, 0.43)]
        [TestCase(-1, 0, 1, 0, 0, 1.73, 1.73)]
        [TestCase(6, 0, 7, 0, 6.5, 0.866, 0.43)]
        public void TestEquilateralTriangleArea(double xA, double yA, double xB, double yB, double xC, double yC, double expectedArea)
        {
            Point vertexA = new Point((int)xA, (int)yA);
            Point vertexB = new Point((int)xB, (int)yB);
            Point vertexC = new Point((int)xC, (int)yC);
            EquilateralTriangle equilateralTriangle = new EquilateralTriangle(vertexA, vertexB, vertexC);

            double area = equilateralTriangle.GetArea();

            Assert.AreEqual(expectedArea, area);
        }

        [TestCase(0, 0, 1, 0, 0.5, 0.866, ExpectedResult =3)]
        [TestCase(-1, 0, 1, 0, 0, 1.73, ExpectedResult =6)]
        [TestCase(6, 0, 7, 0, 6.5, 0.866, ExpectedResult =3)]
        public double TestEquilateralTrianglePerimeter(double xA, double yA, double xB, double yB, double xC, double yC)
        {
            Point vertexA = new Point((int)xA, (int)yA);
            Point vertexB = new Point((int)xB, (int)yB);
            Point vertexC = new Point((int)xC, (int)yC);
            EquilateralTriangle equilateralTriangle = new EquilateralTriangle(vertexA, vertexB, vertexC);

            return equilateralTriangle.GetPerimeter();
        }

        [TestCase(0, 0, 1, 0, 0.5, 0.866, ExpectedResult = "Type: EquilateralTriangle, Area: 0,43; Perimeter: 3")]
        [TestCase(-1, 0, 1, 0, 0, 1.73, ExpectedResult = "Type: EquilateralTriangle, Area: 1,73; Perimeter: 6")]
        public string TestEquilateralTriangleToString(double xA, double yA, double xB, double yB, double xC, double yC)
        {
            Point vertexA = new Point((int)xA, (int)yA);
            Point vertexB = new Point((int)xB, (int)yB);
            Point vertexC = new Point((int)xC, (int)yC);
            EquilateralTriangle equilateralTriangle = new EquilateralTriangle(vertexA, vertexB, vertexC);

            return equilateralTriangle.ToString();
        }
    }
}
