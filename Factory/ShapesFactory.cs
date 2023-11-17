using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class ShapeFactory
    {
        public static Shape CreateShape(string shapeType)
        {
            switch (shapeType)
            {
                case "Triangle":
                    return new Triangle();
                case "Circle":
                    return new Circle();
                // Додайте відповідні випадки для інших фігур
                default:
                    throw new ArgumentException($"Не відомий тип фігури: {shapeType}");
            }
        }
    }
}
