namespace Exercice16_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int f = 0;
            Console.WriteLine("Choisis un nombre d'éléments à calculer");
            f = int.Parse(Console.ReadLine());
            
           

            int[] tab = new int[f];

            if (f >= 1)
            {
             tab[0] = 0; 
            }

            if (f >= 2)
            { 
                tab[1] = 1;
            }

            for (int i = 2; i < tab.Length; i++)
            { tab[i] = tab[i - 1] + tab[i - 2]; }


            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }



        }
    }
}
