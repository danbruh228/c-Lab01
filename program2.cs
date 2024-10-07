Rectangle rectangle = new Rectangle(5, 6);

Console.Write("Area = "); Console.WriteLine(rectangle.Area);
Console.Write("Perimeter = "); Console.WriteLine(rectangle.Perimeter);
class Rectangle
{
    readonly double _sideA;
    readonly double _sideB;
    public Rectangle(double sideA, double sideB)
    {
        _sideA = sideA;
        _sideB = sideB;
    }
    private double CalculateArea()
    {
        return _sideA * _sideB;
    }
    private double CalculatePerimeter()
    {
        return 2 * (_sideA + _sideB);
    }
    public double Area
    {
        get {return CalculateArea();}
    }
    public double Perimeter
    {
        get {return CalculatePerimeter();}
    }
}
