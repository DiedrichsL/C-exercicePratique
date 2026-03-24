using System.Drawing;
using System.Xml.Linq;

namespace Exercice34_Shape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(5, 10, "Rouge", "MonRectangle");
            Circle c = new Circle(7, "GrandCercle", "Bleu");
            Triangle t = new Triangle(8, 5, "Vert", "MoyenTriangle");
            Square s = new Square(6, "CarréParfait", "Jaune");

            Console.WriteLine($"{ r.name},{r.color},{r.CalculateArea()}");
            Console.WriteLine($"{c.name},{c.color},{c.CalculateArea()}");
            Console.WriteLine($"{t.name},{t.color},{t.CalculateArea()}");
            Console.WriteLine($"{s.name},{s.color},{s.CalculateArea()}");

            
            
        }
    }
}