const int BASE = 4;
int fromage = 800;
decimal eau = 2.0M;
decimal ail = 2.0M;
decimal pain = 400.0M;
int nbConvives = 0;



Console.WriteLine("Entrez le nombre de personne pour préparer la recette ");
nbConvives = int.Parse(Console.ReadLine());
fromage = fromage * nbConvives / BASE;
eau = eau * nbConvives / BASE;
ail = ail * nbConvives / BASE;
pain = pain * nbConvives / BASE;

Console.WriteLine($@"Pour faire une fondue fribourgeoise pour {nbConvives} personnes, il vous faut:
- {fromage} gr de Vacherin fribourgeois
- {eau} dl d'eau
- {ail} gousse d'ail
- {pain}; gr de pain
- Du poivre à volonté");
