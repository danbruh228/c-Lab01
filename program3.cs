using System.Diagnostics;

Point p1 = new Point(0, 0);
Point p2 = new Point(0, 3);
Point p3 = new Point(4, 0);
Figure triangle = new Figure(p1, p2, p3);
Debug.Assert(triangle.name == "Треугольник");
Debug.Assert(triangle.PerimeterCalculator() == 12);

Console.WriteLine($"Название фигуры: {triangle.name}");
Console.WriteLine($"Периметр фигуры: {triangle.PerimeterCalculator()}");

// Пример для четырехугольника
Point p4 = new Point(4, 4);
Figure tetragon = new Figure(p1, p2, p3, p4);
Debug.Assert(tetragon.name == "Четырехугольник");

Console.WriteLine($"Название фигуры: {tetragon.name}");
Console.WriteLine($"Периметр фигуры: {tetragon.PerimeterCalculator()}");

// Пример для пятиугольника
Point p5 = new Point(0, 4);
Figure pentagon = new Figure(p1, p2, p3, p4, p5);
Debug.Assert(pentagon.name == "Пятиугольник");
Debug.Assert(pentagon.PerimeterCalculator() == 20);

Console.WriteLine($"Название фигуры: {pentagon.name}");
Console.WriteLine($"Периметр фигуры: {pentagon.PerimeterCalculator()}");

class Point
{
    private int x;
    private int y;

    public Point(int _x, int _y)
    {
        x = _x;
        y = _y;
    }

    public int X
    {
        get { return x; }
    }

    public int Y
    {
        get { return y; }
    }
}

class Figure
{
    public string name { get; set; }
    private List<Point> points = new List<Point>();

    public Figure(Point p1, Point p2, Point p3)
    {
        name = "Треугольник";
        points.Add(p1);
        points.Add(p2);
        points.Add(p3);
    }
    public Figure(Point p1, Point p2, Point p3, Point p4) : this(p1, p2, p3)
    {
        name = "Четырехугольник";
        points.Add(p4);
    }
    public Figure(Point p1, Point p2, Point p3, Point p4, Point p5) : this(p1, p2, p3, p4)
    {
        name = "Пятиугольник";
        points.Add(p5);
    }
    public double LengthSide(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    public double PerimeterCalculator()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Count; i++)
        {
            Point A = points[i];
            Point B = points[(i + 1) % points.Count];
            perimeter += LengthSide(A, B);
        }

        return perimeter;
    }
}
