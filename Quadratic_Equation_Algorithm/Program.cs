using System;

namespace Quadratic_Equation_Algorithm;

class program
{
    static void Main()
    {
        Console.WriteLine("Enter value for a, b, and c.");

        Console.Write("a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("c: ");
        double c = Convert.ToDouble(Console.ReadLine());
    }

    static void QuadraticEquation(double a, double b, double c)
    {
        double delta = b * b - 4 * a * c;

        Console.WriteLine($"delta: {delta}");

        if (delta > 0)
        {
            // Two natural elements
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine($"x1 = {x1}, x2 = {x2}");
        }
        else if (delta == 0)
        {
            // One natural element
            double x = -b / (2 * a);

            Console.WriteLine($"x = {x}");
        }
        else
        {
            // No real elements
            double realElement = -b / (2 * a);
            double imagElement = Math.Sqrt(-delta) / (2 * a);

            Console.WriteLine($"x1 = {realElement} + {imagElement}, x2 = {realElement} - {imagElement} ");
        }
    }
}