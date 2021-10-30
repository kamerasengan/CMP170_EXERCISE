using System;

namespace Shape
{
    public interface IShape
    {
        void Draw(int x, int y); // methods
        string Name { get; } // property
    }
    public class Rectangle : IShape
    {
        public void Draw(int x, int y)
        {
            Console.Write(string.Format("Drawing a rectangle({ 0}-{ 1})", x, y));
        }
        public string Name
        {
            get
            {
                return "Rectangle";
            }
        }
        public class Circle : IShape
        {
            public void Draw(int x, int y)
            {
                Console.Write(string.Format("Drawing a circle({ 0}-{ 1})", x, y));
            }
            public string Name => "Circle";
        }

        class Program
        {
            static void Main(string[] args)
            {
                var shapes = new ArrayList();
                // Assignment
                shapes.Add(new Rectangle());
                shapes.Add(new Circle());
                // Method calls
                for (int i = 0; i < shapes.length; i++)
                {
                    shapes[i].Draw((i + 1) * 10, (i + 1) * 10);
                }
                // Type check
                int circleTotal = 0;
                for (int i = 0; i < shapes.length; i++)
                {
                    if (shapes[i] is Circle) circleTotal++;
                }
                Console.Write(string.Format("There is { 0 } circles in the list", circleTotal));
            }
        }
    }
}
