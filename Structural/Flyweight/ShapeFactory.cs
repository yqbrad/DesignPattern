using System;
using System.Collections.Generic;

namespace Flyweight
{
    public class ShapeFactory
    {
        private Dictionary<string, IShape> _shapes = new();
        public int ShapeCount { get => _shapes.Count; }

        public IShape GetShape(string name)
        {
            if (_shapes.ContainsKey(name))
                return _shapes[name];

            if (name is "Circle")
            {
                var shape = new Circle();
                _shapes.Add(name, shape);
                return shape;
            }


            if (name is "Rectangle")
            {
                var shape = new Rectangle();
                _shapes.Add(name, shape);
                return shape;
            }

            throw new Exception();
        }
    }
}