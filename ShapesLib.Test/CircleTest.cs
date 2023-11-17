using NUnit.Framework;
using ShapesLib;
using System.Drawing;

namespace ShapesLib.Tests
{
    [TestFixture]
    public class CircleTests
    {
        [TestCase(0, 0, 5, ExpectedResult = "Circle")]
        [TestCase(2, 3, 7, ExpectedResult = "Circle")]
        public string TestCircleConstructor(int centerX, int centerY, double radius)
        {
            Point center = new Point(centerX, centerY);
            Circle circle = new Circle(center, radius);

            return circle.Name;
        }

        [TestCase(0, 0, 5, ExpectedResult = 78.54)]
        [TestCase(2, 3, 7, ExpectedResult = 153.94)]
        [TestCase(5, 1, 4, ExpectedResult = 50.27)]
        [TestCase(-1, -3, 9, ExpectedResult = 254.47)]
        [TestCase(6, 2, 2, ExpectedResult = 12.57)]
        public double TestCircleArea(int centerX, int centerY, double radius)
        {
            Point center = new Point(centerX, centerY);
            Circle circle = new Circle(center, radius);

            double area = circle.GetArea();

            return area;
        }

        [TestCase(0, 0, 5, ExpectedResult = 31.42)]
        [TestCase(2, 3, 7, ExpectedResult = 43.98)]
        [TestCase(5, 1, 4, ExpectedResult = 25.13)]
        [TestCase(-1, -3, 9, ExpectedResult = 56.55)]
        [TestCase(6, 2, 2, ExpectedResult = 12.57)]
        public double TestCirclePerimeter(int centerX, int centerY, double radius)
        {
            Point center = new Point(centerX, centerY);
            Circle circle = new Circle(center, radius);

            double perimeter = circle.GetPerimeter();

            return perimeter;
        }

        [TestCase(0, 0, 5, ExpectedResult = "Type: Circle, Area: 78,54; Perimeter: 31,42")]
        [TestCase(2, 3, 7, ExpectedResult = "Type: Circle, Area: 153,94; Perimeter: 43,98")]
        [TestCase(5, 1, 4, ExpectedResult = "Type: Circle, Area: 50,27; Perimeter: 25,13")]
        [TestCase(-1, -3, 9, ExpectedResult = "Type: Circle, Area: 254,47; Perimeter: 56,55")]
        [TestCase(6, 2, 2, ExpectedResult = "Type: Circle, Area: 12,57; Perimeter: 12,57")]
        public string TestCircleToString(int centerX, int centerY, double radius)
        {
            Point center = new Point(centerX, centerY);
            Circle circle = new Circle(center, radius);

            string result = circle.ToString();

            return result;
        }
    }


}

