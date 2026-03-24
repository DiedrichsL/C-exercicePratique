int argentTotal = 0;
int argentLivre = 0;

Console.WriteLine("Combien d'argent avez-vous reçu ?");
argentTotal=int.Parse(Console.ReadLine());
argentLivre = argentTotal / 4 * 3;

int nbcafe = 0;
int nbmetro = 0;
int nbFlash = 0;
int ArgentRestant = 0;
int ArgentRestant2 = 0;

ArgentRestant = argentTotal - argentLivre;
ArgentRestant2 = ArgentRestant / 3;
nbcafe = ArgentRestant2 / 2;
nbFlash = ArgentRestant2 / 4;
nbmetro = ArgentRestant2 / 3;
ArgentRestant2 = ArgentRestant2 % 2 + ArgentRestant2 % 4 + ArgentRestant2 % 3 + ArgentRestant % 3;





Console.WriteLine($@"Livres et Fourniture : {argentLivre}Frs.
Vous pouvez ensuite acheter {nbcafe} café
{nbFlash} numéros du Flash
{nbmetro} billets de métro
et il vous restera {ArgentRestant2} Frs pour les roses rouges");



