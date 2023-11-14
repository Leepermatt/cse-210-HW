using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        
        Square s1 = new Square("white", 5);
        shapes.Add(s1);
        Rectangle r1 = new Rectangle("blue", 5, 4);
        shapes.Add(r1);
        Circle c1 = new Circle("orange", 3);
        shapes.Add(c1);
        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
            
        }
    }
}