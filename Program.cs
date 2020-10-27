using System;

namespace Lab1CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2, D;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            D = Math.Sqrt(b * b - 4 * a * c);
            x1 = (-b + D) / 2 * a;
            x2 = (-b - D) / 2 * a;
            Console.WriteLine($"X1 = {x1} X2 = {x2}");
            if (x1 > 0 && x2 > 0)
            {
                Console.WriteLine(true);
            }
            else Console.WriteLine(false);
        }
    }
}
