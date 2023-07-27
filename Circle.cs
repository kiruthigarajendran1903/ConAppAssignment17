using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignmnet17
{
    public class Circle : Shape
    {
        double radius;

        public Circle(double radius)
        {
            ShapeType = "Circle";
            this.radius = radius;
        }



        public override double Area => Math.PI * radius * radius;

        public override double Perimeter => 2 * Math.PI * radius;


        public virtual void PrintInfo()
        {
            Console.WriteLine($"Shape Type: {ShapeType}");
            Console.WriteLine($"Radius: {radius}");
            Console.WriteLine($"Area: {Area}");
            Console.WriteLine($"Perimeter: {Perimeter}");
            Console.WriteLine();
        }
    }
   
}

