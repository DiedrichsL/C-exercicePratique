namespace Exercice18_PuissanceDe2Nombres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez un nombre");
            int nb1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez la puissance");
            int puissance = int.Parse(Console.ReadLine());
            int resultat = Puissance(nb1, puissance);
            Console.WriteLine($"la puissance est:{resultat}");

        }

        static int Puissance(int nb1, int puissance)
        { 
        int resultat = 1;
        for (int i = 0; i < puissance; i++)
        { 
            resultat = resultat* nb1;
        }       

         return resultat;
   
    }
    }



}
