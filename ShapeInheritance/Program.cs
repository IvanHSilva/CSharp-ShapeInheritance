using ShapeInheritance.Entities;
using ShapeInheritance.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ShapeInheritance {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Número de figuras: ");
            int n = int.Parse(Console.ReadLine());
            List<Shape> shapes = new List<Shape>();
            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Figura {i}:");
                Console.Write("Retângulo ou Círculo (r/c)? ");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Cor: ");
                Color color = (Color)Enum.Parse(typeof(Color), Console.ReadLine());
                if (resp == 'r' || resp == 'R') {
                    Console.Write("Largura: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Altura: ");
                    double heigth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Rectangle(width, heigth, color));
                } else if (resp == 'c' || resp == 'C') {
                    Console.Write("Raio: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Circle(radius, color));
                } else {
                    Console.WriteLine("Figura inválida!");
                    return;
                }
            }
            Console.WriteLine();
            Console.WriteLine("AREAS DAS FIGURAS:");
            foreach (Shape shape in shapes) {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine();
        }
    }
}