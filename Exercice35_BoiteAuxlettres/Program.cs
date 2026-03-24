namespace Exercice35_BoiteAuxLettres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BoiteAuxLettres boite = new BoiteAuxLettres();

            boite.Ajouter(new Lettre(200, true, "Chemin des Acacias 28, 1009 Pully", "A3"));
            boite.Ajouter(new Colis(3000, true, "Chemin des fleurs 48, 2800 Delemont", 70));
            boite.Ajouter(new Publicite(150, false, "Rue du Lac 12, 1020 Renens"));
            boite.Ajouter(new Lettre(100, false, "", "A4"));

            Console.WriteLine("Contenu de la boîte aux lettres :");
            Console.WriteLine();
            boite.Afficher();

            Console.WriteLine($"Montant total d'affranchissement : {boite.Affranchir():0.0} CHF");
            boite.CourrierInvalide();

            Console.ReadKey();
        }
    }
}