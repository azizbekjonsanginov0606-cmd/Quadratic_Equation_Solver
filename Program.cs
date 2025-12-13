using System;
using static System.Math;
class Muodilai_kivatrai
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
        double x1, x2;
        Console.WriteLine($"D = {d}");
        if (d >= 0)
        {
            x1 = (-b + Sqrt(d) )/ (2 * a);
            x2 = (-b - Sqrt(d)) / (2 * a);
            Console.Write($"x1 = {x1}");
            Console.Write($"\tx2 = {x2}");
        }
        else
        {
            Console.WriteLine("Muodila hal nadorad");
        }
    }

}
