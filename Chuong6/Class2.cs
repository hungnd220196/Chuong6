
namespace Chuong6
{
    public class Point : Shape
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a point at ({X}, {Y})");
        }
    }

    public class Line : Shape
    {
        public Point Start { get; set; }
        public Point End { get; set; }

        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a line from ({Start.X}, {Start.Y}) to ({End.X}, {End.Y})");
        }
    }

    public class Circle : Shape
    {
        public Point Center { get; set; }
        public double Radius { get; set; }

        public Circle(Point center, double radius)
        {
            Center = center;
            Radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a circle with center at ({Center.X}, {Center.Y}) and radius {Radius}");
        }
    }

    public class Rectangle : Shape
    {
        public Point TopLeft { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(Point topLeft, double width, double height)
        {
            TopLeft = topLeft;
            Width = width;
            Height = height;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a rectangle with top-left corner at ({TopLeft.X}, {TopLeft.Y}), width {Width}, and height {Height}");
        }
    }

    public class Square : Rectangle
    {
        public Square(Point topLeft, double sideLength) : base(topLeft, sideLength, sideLength)
        {
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a square with top-left corner at ({TopLeft.X}, {TopLeft.Y}) and side length {Width}");
        }
    }

    public class Triangle : Shape
    {
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }

        public Triangle(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a triangle with vertices at ({A.X}, {A.Y}), ({B.X}, {B.Y}), ({C.X}, {C.Y})");
        }
    }

    // hinh binh hanh
    public class Parallelogram : Shape
    {
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }
        public Point D { get; set; }

        public Parallelogram(Point a, Point b, Point c, Point d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a parallelogram with vertices at ({A.X}, {A.Y}), ({B.X}, {B.Y}), ({C.X}, {C.Y}), ({D.X}, {D.Y})");
        }
    }

    //hinh thoi
    public class Rhombus : Shape
    {
        public Point Center { get; set; }
        public double Diagonal1 { get; set; }
        public double Diagonal2 { get; set; }

        public Rhombus(Point center, double diagonal1, double diagonal2)
        {
            Center = center;
            Diagonal1 = diagonal1;
            Diagonal2 = diagonal2;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a rhombus with center at ({Center.X}, {Center.Y}), diagonals {Diagonal1} and {Diagonal2}");
        }
    }







}
