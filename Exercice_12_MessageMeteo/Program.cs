namespace Exercice_12_MessageMeteo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Veuillez chosir la plage de température actuelle 
                Option 1 : > 15° 
                Option 2 : < 10° 
                Option 3 : > 30°");
                

            int temperature;
            temperature = int.Parse(Console.ReadLine());
            switch (temperature)

                { 
                  case 1: Console.WriteLine(" Temperature idéal");
                    break;
                

           
                  case 2:
                    Console.WriteLine(" Attention au verglas");
                    break;

                case 3:
                    Console.WriteLine("Attention au soleil");
                    break;

               default: Console.WriteLine("L'option n'est pas possible");
                    break;
            }

            }
        }
}
