using System;
public class Rectangle : Shape
{
    protected double _side;
    protected double _otherSide;
    public Rectangle (string color, double side, double otherSide) : base (color)
    {
        _otherSide = otherSide;
        _side = side;
    }
    public override double GetArea()
    {
        return _side * _otherSide;
    }
}
