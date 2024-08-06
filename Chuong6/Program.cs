namespace Chuong6
{
    internal class Tester
    {
        static void Main(string[] args)
        {
            //test base
            Student student = new Student();
            student.ShowInfo();


            //demo
            Employee emp1 = new Employee("Hung",1000);
            SalesEmployee emp2 = new SalesEmployee("Duc",1000,400);
            Console.WriteLine($"Nhân viên {emp1.name} \t total salary: {emp1.CalculatePay()}" );
            Console.WriteLine($"Nhân viên {emp2.name} \t total salary: {emp2.CalculatePay()}" );

            //bt
            List<Shape> shapes = new List<Shape>
            {
            new Point(1, 2),
            new Line(new Point(0, 0), new Point(1, 1)),
            new Circle(new Point(5, 5), 3),
            new Rectangle(new Point(0, 0), 4, 2),
            new Square(new Point(2, 2), 3),
            new Triangle(new Point(0, 0), new Point(1, 0), new Point(0, 1)),
            new Parallelogram(new Point(0, 0), new Point(2, 0), new Point(3, 1), new Point(1, 1)),
            new Rhombus(new Point(0, 0), 4, 3)
            };

            foreach (Shape shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
