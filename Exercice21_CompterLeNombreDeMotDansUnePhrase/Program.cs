namespace Exercice21_CompterLeNombreDeMotDansUnePhrase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase = "";
            Console.WriteLine("Entrer une phrase:");
            phrase = Console.ReadLine();
            int nbMots = phrase.Split(" ").Length;
            Console.WriteLine(($"La phrase contient {nbMots} mot(s)"));
        }
    }
}
