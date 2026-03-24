namespace Exercice_13_SommesDeDeuxNombre
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Saisis 2 nombres");
            int nb1 = int.Parse(Console.ReadLine());
            int nb2 = int.Parse(Console.ReadLine());
            int resultat = Sommes(nb1, nb2);
            Console.WriteLine(resultat);
        }


        static int Sommes(int nb1, int nb2)

        {
            
            int resultat = nb1 + nb2;
            return resultat;

        }
     }
    
}
