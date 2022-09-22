using System;
using Figure;

class Program
{
    static void Main()
    {
        Point.Point one = new(12, 12);
        Point.Point two = new(10, 13);
        Point.Point three = new(14, 14);
        Point.Point four = new(23, 56);
        Figure.Figure test = new(one, two, three, four);
        test.Name = "pupa";
        Console.WriteLine(test.PerimeterCalculator());
    }
}