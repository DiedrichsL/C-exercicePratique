using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace Exercice19_EstCePairBis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nombres = { 2, 4, 3, 5, 8 };
            for (int i = 0; i < nombres.Length; i++)
                if (nombres[i] % 2 == 0) 
            {
                Console.WriteLine($"le chiffre {nombres[i]} est pair");
            }
              else
            {
                Console.WriteLine($"Le chiffre {nombres[i]} est impair");
            }
        }
    }
}
