using ShapesLib;
using System;
using System.Drawing;

namespace ShapesLib
{
    public abstract class ShapesUnusual : Shape
    {
        protected Point center;

        public ShapesUnusual(string name, Point center) : base(name)
        {
            this.center = center;
        }
    }
}