namespace Exercice31_LeJeuDeCarte
{
    public  class Program
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine("Jeu de la Bataille");

                Console.Write("Pseudo du joueur 1 : ");
                string pseudo1 = Console.ReadLine();

                Console.Write("Pseudo du joueur 2 : ");
                string pseudo2 = Console.ReadLine();

           
                Deck deck1 = new Deck();
                Deck deck2 = new Deck();

                Joueur joueur1 = new Joueur(pseudo1, deck1);
                Joueur joueur2 = new Joueur(pseudo2, deck2);

                Partie partie = new Partie(joueur1, joueur2);

                partie.Demarrer();

                Console.WriteLine("Appuie sur une touche pour quitter...");
                Console.ReadKey();
            }


        }
    }
}
