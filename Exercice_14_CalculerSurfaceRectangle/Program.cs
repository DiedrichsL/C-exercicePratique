namespace Exercice_14_CalculerSurfaceRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;


            Console.WriteLine($"Entrez le premier côté (x) :  ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine($"Entrez le deuxième côté (y) : ");      
            y = int.Parse( Console.ReadLine() );
            int resultat = CalculerSurface(x, y);
            Console.WriteLine($"La surface est de : {resultat}");
            

        }

        static int CalculerSurface(int x, int y)
        { int resultat = x * y;
        return  resultat;
        }
    }
}
