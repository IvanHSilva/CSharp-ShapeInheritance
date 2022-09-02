using ShapeInheritance.Entities.Enums;

namespace ShapeInheritance.Entities {
    public class Rectangle : Shape {
        // Attributes
        public double Width { get; set; }
        public double Height { get; set; }

        // Contructors
        public Rectangle() { }

        public Rectangle(double width, double height, Color color) : base(color) {
            Width = width;
            Height = height;
        }

        // Methods
        public override double Area() {
            return Width * Height;
        }
    }
}
