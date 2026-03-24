namespace Exercice_11_EstCePair
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nombre = 0;
            Console.WriteLine("Entrez un nombre");
            nombre = int.Parse(Console.ReadLine());
            nombre = nombre % 2;
            if (nombre == 0) 
            {
                Console.WriteLine("Pair");
            }

            else
                Console.WriteLine("Impair");
        }
    }

}

