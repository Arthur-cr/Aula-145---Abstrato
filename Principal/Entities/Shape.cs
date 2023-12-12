using System;
using System.Collections.Generic;
using Principal.Entities.Enums;

namespace Principal.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }
        public abstract double Area();
       
    }
}
