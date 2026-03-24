

int numero = 0;
bool choixvalide = true, continuer = true;
string choix = "";

do
{
    Console.WriteLine(@"Quelle coueleur voulez-vous ?
-1 : Rouge
-2 : Vert
-3 : Bleu 
-4 : Jaune
-5 : Blanc");
    Console.WriteLine("Quelle couleur voulez-vous ");

    numero = int.Parse(Console.ReadLine());

    switch (numero)
    {

        case 1:
            Console.ForegroundColor = ConsoleColor.Red;
            break;
        case 2:
            Console.ForegroundColor = ConsoleColor.Green;
            break;
        case 3:
            Console.ForegroundColor = ConsoleColor.Blue;
            break;
        case 4:
            Console.ForegroundColor = ConsoleColor.Yellow;
            break;
        case 5:
            Console.ForegroundColor = ConsoleColor.White;
            break;


        default:
            choixvalide = false;
            break;
    }
    if (choixvalide == true)
    {
        Console.WriteLine("Ceci est un texte de couleur");
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    else
    {
        Console.WriteLine("Cette option est impossible");
    }
    while (choix != "oui" && choix != "non")
    {
        Console.WriteLine("voulez-vous saisir une autre couleur ( oui / non ) ");
        choix = Console.ReadLine();

        if (choix == "non")
        {
            continuer = false;
        }
        else
        {
            Console.Clear();
        }
    }
} while (continuer);