///SurfaceAreaOfCylinder
using System;
using static System.Math;

namespace SurfaceAreaOfCylinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string radiusString;
            string heightString;
            double radius;
            double height;
            double volume;
            double area;

            radius = 0;
            height = 0;
            volume = 0;
            area = 0;

            Console.WriteLine("Welcome to Cylinder Calculator 1.0");
            Console.ReadKey();
            Console.WriteLine();

            //Get radius input
            Console.Write("Enter the cylinder's radius:  ");
            radiusString = Console.ReadLine();
            radius = Convert.ToDouble(radiusString);

            //Get height input
            Console.Write("Enter the cyclinder's height:  ");
            heightString = Console.ReadLine();
            height = Convert.ToDouble(heightString);

            //Calculate Volume and Area
            volume = PI * radius * radius * height;
            area = 2 * PI * radius * (radius + height);

            //Output
            Console.WriteLine();
            Console.WriteLine("The Cylinder's Volume is: {0:F2} cubic units" , volume);
            Console.WriteLine("The Cylinder's Surface Area is: {0:F2} square units" , area);
            Console.ReadKey();
        }
    }
}
