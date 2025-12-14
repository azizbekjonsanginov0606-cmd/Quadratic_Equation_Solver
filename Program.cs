using System;
using static System.Math;
class Quadratic_Equation_Solver
{
    static void Main()
    {
        Console.Write("a=");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b=");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("c=");
        double c = Convert.ToDouble(Console.ReadLine());
        double d = Pow(b,2) - 4 * a * c;
        double x, x1, x2;
        Console.WriteLine($"D = {d}");
        if (d > 0)
        {
            x1 = (-b + Sqrt(d) )/ (2 * a);
            x2 = (-b - Sqrt(d)) / (2 * a);
            Console.WriteLine($"Roots are x1 = {x1}");
            Console.WriteLine($"Roots are x2 = {x2}");
        }
        else if (d == 0)
        {
            x = (-b)/ (2 * a);
            Console.Write($"Roots are x = {x}");
        }
        else
        {
            Console.WriteLine("No real roots");
        }
    }

}
