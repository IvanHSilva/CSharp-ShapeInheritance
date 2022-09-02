using ShapeInheritance.Entities.Enums;

namespace ShapeInheritance.Entities {
    public class Circle : Shape {
        public const double PI = 3.1415;

        // Attributes
        public double Radius { get; set; }

        // Contructors
        public Circle() { }

        public Circle(double radius, Color color) : base(color) {
            Radius = radius;
        }

        // Methods
        public override double Area() {
            return Radius * (PI * PI);
        }

    }
}
