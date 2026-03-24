Random rng = new Random();
int nombreAleatoire = rng.Next(1, 101);
int nombrechoisis = 0;
string choix = "";



do
{
    Console.WriteLine("Devinez le nombre entre 1 et 100");


    do
    {
        nombrechoisis = int.Parse(Console.ReadLine());
        if (nombrechoisis < nombreAleatoire)
        {
            Console.WriteLine("Le nombre est plus grand");
        }

        else if (nombrechoisis > nombreAleatoire)
        {
            Console.WriteLine("Le nombre est plus petit");
        }

    } while (nombreAleatoire != nombrechoisis) ;


      Console.WriteLine("Victoire !!!");





    while (choix != "oui" && choix != "non")
    {
    Console.Write("Voulez-vous recommencer (oui / non)");
    choix = Console.ReadLine();
    }

} while (choix == "oui") ;