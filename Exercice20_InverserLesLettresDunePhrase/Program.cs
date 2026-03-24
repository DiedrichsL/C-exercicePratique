namespace Exercice20_InverserLesLettresDunePhrase
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entrez une phrase");
            string phrase = "";
            phrase = (Console.ReadLine());
            string phraseInversee = "";
            foreach ( char c in phrase)
            { phraseInversee = c + phraseInversee; }

            Console.WriteLine(phraseInversee);
        }
    }
}
