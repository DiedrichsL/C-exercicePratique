namespace Exercice10_LeJustePrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double TVA = 0;
            double prixHT = 0;
            double prixTVA;
            Console.WriteLine("saisissez un Prix HT");
            prixHT = int.Parse(Console.ReadLine());
            prixTVA = prixHT / 100 * 8.1 + prixHT;
            TVA = prixTVA - prixHT;

            Console.WriteLine(@$"Quel est le pris HT : {prixHT}
            TTC : {prixTVA}
            TVA : {TVA}");
            

        }
    }
}
