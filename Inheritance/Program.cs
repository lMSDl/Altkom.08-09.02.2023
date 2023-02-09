using Inheritance.Models;


Shape1D shape1D = new Point();
Shape shape = shape1D;

Line line = new Line(10);

//polimorfizm - możliwość przedstawienia jednej klasy jako inna klasa (w zakresie hierarchi dziedziczenia)
List<Shape> shapes = new List<Shape>();
shapes.Add(shape1D);
shapes.Add(line);
shapes.Add(new Line(5));
shapes.Add(new Square(5));
shapes.Add(new Rectangle(5, 10));

foreach (Shape item in shapes)
{
    //item.SomeAbstractMethod();
    Console.WriteLine(item.ToString());

}


