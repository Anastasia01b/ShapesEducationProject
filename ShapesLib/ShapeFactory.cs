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
        factories["equilateraltriangle"] = parameters => CreateEquilateralTriangle(parameters);
    }

    private Shape CreateTriangle(string[] parameters)
    {
        ValidateParameters(parameters, 6);

        Point vertexA = GetPoint(parameters, 0);
        Point vertexB = GetPoint(parameters, 2);
        Point vertexC = GetPoint(parameters, 4);

        return new Triangle(vertexA, vertexB, vertexC);
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

    private Shape CreateRhombus(string[] parameters)
    {
        ValidateParameters(parameters, 8);

        Point vertexA = GetPoint(parameters, 0);
        Point vertexB = GetPoint(parameters, 2);
        Point vertexC = GetPoint(parameters, 4);
        Point vertexD = GetPoint(parameters, 6);

        return new Rhombus(vertexA, vertexB, vertexC, vertexD);
    }

    private Shape CreateRectangle(string[] parameters)
    {
        ValidateParameters(parameters, 8);

        Point vertexA = GetPoint(parameters, 0);
        Point vertexB = GetPoint(parameters, 2);
        Point vertexC = GetPoint(parameters, 4);
        Point vertexD = GetPoint(parameters, 6);

        return new Rectangle(vertexA, vertexB, vertexC, vertexD);
    }

    private Shape CreateSquare(string[] parameters)
    {
        ValidateParameters(parameters, 8);

        Point vertexA = GetPoint(parameters, 0);
        Point vertexB = GetPoint(parameters, 2);
        Point vertexC = GetPoint(parameters, 4);
        Point vertexD = GetPoint(parameters, 6);

        return new Square(vertexA, vertexB, vertexC, vertexD);
    }

     private Shape CreateEquilateralTriangle(string[] parameters)
     {
          ValidateParameters(parameters, 6);

          Point vertexA = GetPoint(parameters, 0);
          Point vertexB = GetPoint(parameters, 2); 
          Point vertexC = GetPoint(parameters, 4);
          return new EquilateralTriangle(vertexA, vertexB, vertexC);
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

