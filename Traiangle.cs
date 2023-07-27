using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignmnet17
{
    public class Traiangle:Shape
    {

        private double sideA;
        private double sideB;
        private double sideC;
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        // Constructor
        public Traiangle(double sideA, double sideB, double sideC)
        {
            ShapeType = "Triangle";
           SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        // Override Area property using Heron's formula
        public override double Area
        {
            get
            {
                double s = (SideA + SideB + SideC) / 2;
                return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
            }
        }

        // Override Perimeter property
        public override double Perimeter => SideA + SideB + SideC;

        // PrintInfo method
        public void PrintInfo()
        {
            Console.WriteLine($"Shape Type: {ShapeType}");
            Console.WriteLine($"Side A: {SideA}");
            Console.WriteLine($"Side B: {SideB}");
            Console.WriteLine($"Side C: {SideC}");
            Console.WriteLine($"Area: {Area}");
            Console.WriteLine($"Perimeter: {Perimeter}");
            Console.WriteLine();
        }
    }
}
