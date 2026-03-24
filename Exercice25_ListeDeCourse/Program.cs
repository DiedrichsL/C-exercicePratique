using System.Threading.Channels;

namespace Exercice25_ListeDeCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {


                string[] tab = { "1kg farine", "500gr sucre", "2 oeufs", "lait" };
                string fichier = @"C:\Users\41796\Dropbox\Mon PC (LAPTOP-1OIEEFR2)\Desktop\Brevet fédéral d'informaticien\liste.txt";
                File.WriteAllLines(fichier, tab);
                string[] tab2 = File.ReadAllLines(fichier);
  

                Console.WriteLine("Quel élément souhaitez vous affichez ? ");
                int numero = int.Parse(Console.ReadLine());
                for (int i = 0; i < tab2.Length; i++)

                {
                    Console.WriteLine(tab2[i]);
                }

                if (numero >= 0 && numero < tab2.Length)

                {
                    Console.WriteLine($"{tab2[numero]}");
                }

                else if (numero) {

            }

            catch (Exception ex)
            {
                Console.WriteLine("chiffre invalide");
            }

            catch (FormatException ex) 
            
            {
                Console.WriteLine("Erreur de format");

        }




    }
}
