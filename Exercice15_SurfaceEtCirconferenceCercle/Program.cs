namespace Exercice15_SurfaceEtCirconferenceCercle
{
    internal class Program
    {
        static void Main(string[] args)

        { 
           
            
            Console.WriteLine("Entrez le rayon du cercle :");
            double rayon = int.Parse(Console.ReadLine());
            
            double air = CalculerAir(rayon);
            Console.WriteLine($"La surface du cercle est: {air}");

            double circ =  CalculerCirc(rayon);
            Console.WriteLine($"La circonférence du cercle est: {circ}");



        }



         static double CalculerAir (double rayon)
        {
            const double PI = 3.14;
            double air = PI * rayon * rayon;
          return air;
        }


        static double CalculerCirc(double rayon)
        { const double PI = 3.14;
            double circ = 2 * PI * rayon;
            return circ;
        }
    }
}
