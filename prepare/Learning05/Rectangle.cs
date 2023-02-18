public class Rectangle : Shape
{
    private double _lenght;
    private double _width;

    public Rectangle(string color, double length, double width) : base(color)
    {
        _lenght = length;
        _width = width;
    }
    public override double GetArea()
    {
        return _lenght * _width;
    }
}