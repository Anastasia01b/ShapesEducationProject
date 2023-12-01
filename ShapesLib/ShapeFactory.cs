using System;
using System.Collections.Generic;
using System.Drawing;
using ShapesLib;

public class ShapeFactory
{
    private Dictionary<string, Func<string[], Shape>> factories;

    public ShapeFactory()
    {
        factories = new Dictionary<string, Func<string[], Shape>>();
        InitializeFactories();
    }

    private void InitializeFactories()
    {
        factories[nameof(Triangle).ToLower()] = parameters => CreateTriangle(parameters);
        factories[nameof(Circle).ToLower()] = parameters => CreateCircle(parameters);
        factories[nameof(Ellipse).ToLower()] = parameters => CreateEllipse(parameters);
        factories[nameof(Square).ToLower()] = parameters => CreateSquare(parameters);
        factories[nameof(Rhombus).ToLower()] = parameters => CreateRhombus(parameters);
        factories[nameof(Rectangle).ToLower()] = parameters => CreateRectangle(parameters);
        factories[nameof(EquilateralTriangle).ToLower()] = parameters => CreateEquilateralTriangle(parameters);
    }
    private Shape CreateCircle(string[] parameters)
    {
        ValidateParameters(parameters, 3);

        Point center = GetPoint(parameters, 0);
        double radius = double.Parse(parameters[2]);

        return new Circle(center, radius);
    }
    private Shape CreateEllipse(string[] parameters)
    {
        ValidateParameters(parameters, 4);

        Point center = GetPoint(parameters, 0);
        double semiMajor = double.Parse(parameters[2]);
        double semiMinor = double.Parse(parameters[3]);

        return new Ellipse(center, semiMajor, semiMinor);
    }
    private Shape CreateEquilateralTriangle(string[] parameters)
    {
        return TriangleCreator(parameters, (a, b, c) => new EquilateralTriangle(a, b, c));
    }
    private Shape CreateTriangle(string[] parameters)
    {
        return TriangleCreator(parameters, (a, b, c) => new Triangle(a, b, c));
    }
   
    private Shape CreateRectangle(string[] parameters)
    {
        return QuadrengleCreator(parameters, 8, (a, b, c, d) => new Rectangle(a, b, c, d));
    }
    private Shape CreateSquare(string[] parameters)
    {
        return QuadrengleCreator(parameters, 8, (a, b, c, d) => new Square(a, b, c, d));
    }
    private Shape CreateRhombus(string[] parameters)
    {
        return QuadrengleCreator(parameters, 8, (a, b, c, d) => new Rhombus(a, b, c, d));
    }
    private Shape QuadrengleCreator(string[] parameters, int expectedCount, Func<Point, Point, Point, Point, Shape> shapeCreator)
    {
        ValidateParameters(parameters, expectedCount);

        Point vertexA = GetPoint(parameters, 0);
        Point vertexB = GetPoint(parameters, 2);
        Point vertexC = GetPoint(parameters, 4);
        Point vertexD = GetPoint(parameters, 6);

        return shapeCreator(vertexA, vertexB, vertexC, vertexD);
    }
    private Shape TriangleCreator(string[] parameters, Func<Point, Point, Point, Shape> triangleCreator)
    {
        ValidateParameters(parameters, 6);

        Point vertexA = GetPoint(parameters, 0);
        Point vertexB = GetPoint(parameters, 2);
        Point vertexC = GetPoint(parameters, 4);

        return triangleCreator(vertexA, vertexB, vertexC);
    }
    private static void ValidateParameters(string[] parameters, int expectedCount)
    {
        if (parameters.Length != expectedCount)
        {
            throw new ArgumentException($"Invalid number of parameters for creating a shape ({expectedCount} expected).");
        }
    }
    private static Point GetPoint(string[] parameters, int startIndex)
    {
        double x, y;
        if (double.TryParse(parameters[startIndex], out x) && double.TryParse(parameters[startIndex + 1], out y))
        {
            return new Point((int)x, (int)y);
        }
        else
        {
            throw new ArgumentException("Invalid input for point coordinates.");
        }
    }
    public Shape CreateShape(string typeName, string[] parameters)
    {
        if (factories.TryGetValue(typeName.ToLower(), out var factory))
        {
            return factory(parameters);
        }
        throw new ArgumentException($"Unsupported shape type: {typeName}");
    }
}


