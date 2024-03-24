using System;

public class Point2D
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point2D(double x, double y)
    {
        X = x;
        Y = y;
    }

    public void Move(double dx, double dy)
    {
        X += dx;
        Y += dy;
    }

    public override string ToString()
    {
        return $"Point2D({X}, {Y})";
    }
}

public class Point3D : Point2D
{
    public double Z { get; set; }

    public Point3D(double x, double y, double z) : base(x, y)
    {
        Z = z;
    }

    public void Move(double dx, double dy, double dz)
    {
        base.Move(dx, dy);
        Z += dz;
    }

    public override string ToString()
    {
        return $"Point3D({X}, {Y}, {Z})";
    }
}

class Program
{
    static void Main()
    {
        var point2D = new Point2D(1, 2);
        Console.WriteLine(point2D);
        point2D.Move(3, 4);
        Console.WriteLine(point2D);

        var point3D = new Point3D(5, 6, 7);
        Console.WriteLine(point3D);
        point3D.Move(8, 9, 10);
        Console.WriteLine(point3D);
    }
}