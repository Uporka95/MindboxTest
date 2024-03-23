using MindboxTest;

namespace MindboxTest.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<IFigure> figures = new List<IFigure>();

           figures.Add(new Circle(16));
           figures.Add(new Rectangle(5, 5));
           figures.Add(new Triangle(0,5,6));
           Triangle triangle = new(3, 5, 4);

           bool result = triangle.IsRight;
            foreach (var figure in figures)
           {
                Console.WriteLine("Площадь фигуры " + (figures.IndexOf(figure) + 1) + " : " + figure.Square);
           }
        }
    }
}
