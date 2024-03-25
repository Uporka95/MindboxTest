using Microsoft.VisualBasic.CompilerServices;

namespace MindboxTest
{
    public interface IFigure
    {
        public double Square { get; }
    }

    public class Circle : IFigure
    {
        public double Radius { get; set; }
        public double Square => Math.PI *  Math.Pow(Radius, 2);

        public Circle(double radius)
        {
            Radius = radius;
        }
    }

    public class Triangle : IFigure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double P => (A + B + C) / 2;
        public double Square
        {
            get
            {
                double square = Math.Sqrt(P * (P - A) * (P - B) * (P - C));
                return double.IsNaN(square) ? 0 : square;
            }
        }

        public bool IsRight
        {
            get
            {
                var sides = new List<double>() { A, B, C };
                sides.Sort((x, y) => y.CompareTo(x));
                return Math.Abs(Math.Pow(sides[0], 2) - (Math.Pow(sides[1], 2) + Math.Pow(sides[2], 2))) < 0.1;
            }
        }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
    }

    public class Rectangle : IFigure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double Square => A * B;

        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
        }
    }
}
