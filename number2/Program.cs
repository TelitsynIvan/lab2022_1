using System;
using MyRectangle;


namespace Number2;

    class Program
    {
        static void Main()
        {
            float a, b;
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            Rectangle one = new(a, b);
            Console.WriteLine($"{one.Area}, {one.Perimeter}");
        }
    }