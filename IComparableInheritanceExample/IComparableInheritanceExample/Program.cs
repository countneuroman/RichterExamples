namespace IComparableInheritanceExample;

public static class Program
{
    public static void Main()
    {
        var points = new[]
        {
            new Point(1, 1), 
            new Point(-2, -2)
        };

        if (points[0].CompareTo(points[1]) > 0)
        {
            (points[0], points[1]) = (points[1], points[0]);
        }
        Console.WriteLine("Points from closest to (0, 0) to farthest");
        foreach (Point point in points)
        {
            Console.WriteLine(point);
        }

        Console.ReadLine();
    }
}

public sealed class Point : IComparable<Point>
{
    private int m_x, m_y;

    public Point(int y, int x)
    {
        m_y = y;
        m_x = x;
    }

    public int CompareTo(Point? other)
    {
        return Math.Sign(Math.Sqrt(m_x * m_x + m_y * m_y) 
                         - Math.Sqrt(other.m_x * other.m_x + other.m_y * other.m_y));
    }

    public override string ToString()
    {
        return string.Format($"{m_x}, {m_y}");
    }
}