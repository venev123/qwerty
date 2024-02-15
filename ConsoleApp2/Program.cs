using System;

class Program
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        Console.WriteLine(Math.Cos(x) / (Math.PI - 2 * x) + 16 * x * Math.Cos(x / y) - 2);
    }
}

