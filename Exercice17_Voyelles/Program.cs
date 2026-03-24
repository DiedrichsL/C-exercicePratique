namespace Exercice17_Voyelles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez une phrase:");
            string phrase = (Console.ReadLine());
            
           int compteur = 0;

            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase[i] == 'a' || phrase[i] == 'e' || phrase[i] == 'i'
                 || phrase[i] == 'o' || phrase[i] == 'u' || phrase[i] == 'y'
                 || phrase[i] == 'A' || phrase[i] == 'E' || phrase[i] == 'I'
                 || phrase[i] == 'O' || phrase[i] == 'U' || phrase[i] == 'Y')
                { compteur++; }


            }

            Console.WriteLine($"il y'a {compteur} voyelles dans la phrase");
        }
    }
}
