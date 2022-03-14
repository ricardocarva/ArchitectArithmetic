using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectArithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
            Architect Arithmetic  C#.
            This program has methods to build a program that calculates the material cost for any architect’s floor plan. It can only measure the area of 1 rectangle, 1 circle, and 1 triangle. No loops were used.
            Overall, developing it helps me to practice my skills of working with Methods in C#.
            Author: Ricardo Carvalheira
            */
            Console.WriteLine(GetCost());

            Console.WriteLine("\r\n     Press Enter to close tab...");
            Console.ReadLine();
            Console.Clear();
        }

        public static string GetCost()
        {
            double xOfRectangle;
            double yOfRectangle;
            Console.Write("Enter X axis of the rectangle: ");
            xOfRectangle = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Y axis of the rectangle: ");
            yOfRectangle = Convert.ToDouble(Console.ReadLine());

            double rectArea = Rect(xOfRectangle, yOfRectangle);

            Console.Write("Enter radius of the circle: ");
            double circleRadius = Convert.ToDouble(Console.ReadLine());

            double circleArea = Circle(0.5 * circleRadius);

            double triangleBottom;
            double triangleHeight;
            Console.Write("Enter bottom of the triangle: ");
            triangleBottom = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height of the triangle: ");
            triangleHeight = Convert.ToDouble(Console.ReadLine());
            double triangleArea = Triangle(triangleBottom, triangleHeight);

            double totalArea = rectArea + circleArea + triangleArea;
            int costOfFlooringMaterial = 180;
            double totalCost = totalArea * costOfFlooringMaterial;
            return $"\r\nThe area of the rectangle was {Math.Round(rectArea, 2)}.\r\nThe area of the circle was {Math.Round(circleArea, 2)}.\r\nThe area of the triangle was {Math.Round(triangleArea, 2)}.\r\nThe total cost was {Math.Round(totalCost, 2)} Mexican pesos.";
        }
        static double Rect(double length, double width)
        {
            return length * width;
        }

        static double Circle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        static double Triangle(double bottom, double height)
        {
            return 0.5 * bottom * height;
        }

    }
}
