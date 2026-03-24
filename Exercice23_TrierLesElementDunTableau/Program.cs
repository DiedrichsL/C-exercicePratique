using System.Runtime.Serialization.Formatters;

namespace Exercice23_TrierLesElementDunTableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp;
            int[] nombre = new int[] { 5, 7, 2, 1, 8 };
            for (int i = 0; i < nombre.Length-1; i++)
            {
                for (int j = i + 1; j < nombre.Length; j++)
                {
                    if (nombre[i] < nombre[j])
                    {
                        temp = nombre[i];
                        nombre[i] = nombre[j];
                        nombre[j] = temp;
                    }
                }
                foreach (int value in nombre)
                {
                    Console.Write(value + " ");
                }

                Console.ReadLine();

            }
        }
    }
}
