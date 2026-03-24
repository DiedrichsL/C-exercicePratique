using System.ComponentModel.Design;

string rouge, vert, bleu, jaune, blanc;

int numero;
Console.WriteLine($@"quelle couleur voulez-vous ?
- 1. Rouge
- 2. Vert
- 3. bleu
- 4. jaune
- 5. blanc");

numero = int.Parse(Console.ReadLine());

switch (numero)
{

    case 1 :
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
        Console.WriteLine("cette option est impossible");
        break;

}

if (numero >= 0 && numero < 5)
{ 
Console.WriteLine("Ceci est un texte en couleur");
}


