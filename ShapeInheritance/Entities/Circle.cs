using ShapeInheritance.Entities.Enums;
using System;

namespace ShapeInheritance.Entities {
    public class Circle : Shape {
        // Attributes
        public double Radius { get; set; }

        // Contructors
        public Circle(double radius, Color color) : base(color) {
            Radius = radius;
        }

        // Methods
        public override double Area() {
            return Math.PI * Radius * Radius;
        }
    }
}
