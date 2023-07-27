using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignmnet17
{
    public class Rectangle : Shape
    {
        private double width;
        private double height;
        public Rectangle(double width, double height)
        {
            ShapeType = "Rectangle";
           Width = width;
            Height = height;
        }
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area => width * height;

        // Override Perimeter property
        public override double Perimeter => 2 * (width + height);

        // PrintInfo method
        public void PrintInfo()
        {
            Console.WriteLine($"Shape Type: {ShapeType}");
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Area: {Area}");
            Console.WriteLine($"Perimeter: {Perimeter}");
            Console.WriteLine();
        }
    }

}
