namespace Figure;
using Point;
using System.Collections.Generic;
using System;

public class Figure
{
    List<Point> arr = new List<Point>();
    public Figure(Point a, Point b, Point c)
    {
        arr.Add(a);
        arr.Add(b);
        arr.Add(c);
    }

    public Figure(Point a, Point b, Point c, Point d) :this(a, b, c)
    {
        arr.Add(d);
    }
    
        public Figure(Point a, Point b, Point c, Point d, Point e) :this(a, b, c, d)
    {
        arr.Add(e);
    }

    public string? Name { get; set; }

    public double LengthSide(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow((B.PointX - A.PointX), 2) + Math.Pow((B.PointY - A.PointY), 2));
    }

    public double PerimeterCalculator()
    {
        double P = 0;
        for (int i = 0; i < arr.Count - 1; i++)
        {
            P += LengthSide(arr[i], arr[i + 1]);
        }

        P += LengthSide(arr[0], arr[arr.Count - 1]);
        return P;
    }
}