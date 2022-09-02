using ShapeInheritance.Entities.Enums;

namespace ShapeInheritance.Entities {
    public abstract class Shape {
        // Attributes
        public Color Color { get; set; }

        // Contructors
        public Shape() { }

        public Shape(Color color) {
            Color = color;
        }

        // Methods
        public virtual double Area() {
            return 0.0;
        }
    }
}
