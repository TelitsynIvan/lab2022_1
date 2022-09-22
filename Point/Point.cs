namespace Point;

public class Point
{
    private int x;
    private int y;

    public Point(int a, int b)
    {
        x = a;
        y = b;
    }

    public int PointX
    {
        get
        {
            return x;
        }
    }
    
    public int PointY
    {
        get
        {
            return y;
        }
    }
}