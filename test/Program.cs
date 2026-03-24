using System;

class Program
{
    static void Main()
    {
        Random rng = new Random();
        string choix = "oui";

        while (choix == "oui")
        {
            int nombreAleatoire = rng.Next(1, 101);
            int nombreChoisis;

            do
            {
                Console.WriteLine("Devinez le nombre entre 1 et 100");
                nombreChoisis = int.Parse(Console.ReadLine());

                if (nombreChoisis < nombreAleatoire)
                {
                    Console.WriteLine("Le nombre est plus grand");
                }
                else if (nombreChoisis > nombreAleatoire)
                {
                    Console.WriteLine("Le nombre est plus petit");
                }
                else
                {
                    Console.WriteLine("Victoire !!!");
                }

            } while (nombreChoisis != nombreAleatoire);

       
            do
            {
                Console.Write("Voulez-vous rejouer ? (oui/non) : ");
                choix = Console.ReadLine().ToLower();
            }
            while (choix != "oui" && choix != "non");
        }
    }
}


