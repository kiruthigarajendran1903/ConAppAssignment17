using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignmnet17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            circle.PrintInfo();

            Rectangle rectangle = new Rectangle(4, 6);
            rectangle.PrintInfo();

            Traiangle triangle = new Traiangle(3, 4, 5);
            triangle.PrintInfo();
            Console.ReadKey();


        }
    }
}
