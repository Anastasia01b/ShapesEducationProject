using NUnit.Framework;
using ShapesLib;
using System.Drawing;

namespace ShapesLib.Tests
{
    [TestFixture]
    public class EllipseTests
    {
        [TestCase(0, 0, 5, 3, ExpectedResult = "Ellipse")]
        [TestCase(2, 3, 7, 4, ExpectedResult = "Ellipse")]
        public string TestEllipseConstructor(int centerX, int centerY, double axisSemiMajor, double axisSemiMinor)
        {
            Point center = new Point(centerX, centerY);
            Ellipse ellipse = new Ellipse(center, axisSemiMajor, axisSemiMinor);

            return ellipse.Name;
        }

        [TestCase(0, 0, 5, 3, ExpectedResult = 47.12)]
        [TestCase(2, 3, 7, 4, ExpectedResult = 87.96)]
        public double TestEllipseArea(int centerX, int centerY, double axisSemiMajor, double axisSemiMinor)
        {
            Point center = new Point(centerX, centerY);
            Ellipse ellipse = new Ellipse(center, axisSemiMajor, axisSemiMinor);

            double area = ellipse.GetArea();

            return area;
        }

        [TestCase(0, 0, 5, 3, ExpectedResult = 25.56)]
        [TestCase(2, 3, 7, 4, ExpectedResult = 35.26)]
        public double TestEllipsePerimeter(int centerX, int centerY, double axisSemiMajor, double axisSemiMinor)
        {
            Point center = new Point(centerX, centerY);
            Ellipse ellipse = new Ellipse(center, axisSemiMajor, axisSemiMinor);

            double perimeter = ellipse.GetPerimeter();

            return perimeter;
        }

        [TestCase(0, 0, 5, 3, ExpectedResult = "Type: Ellipse, Area: 47,12; Perimeter: 25,56")]
        [TestCase(2, 3, 7, 4, ExpectedResult = "Type: Ellipse, Area: 87,96; Perimeter: 35,26")]
        public string TestEllipseToString(int centerX, int centerY, double axisSemiMajor, double axisSemiMinor)
        {
            Point center = new Point(centerX, centerY);
            Ellipse ellipse = new Ellipse(center, axisSemiMajor, axisSemiMinor);

            string result = ellipse.ToString();

            return result;
        }
    }
}



