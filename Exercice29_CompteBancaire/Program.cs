namespace Exercice29_CompteBancaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompteBancaire jean = new CompteBancaire("Jean Dupont");
            CompteBancaire john = new CompteBancaire("John Smith");

           
            jean.AdditionMontant(100m);

            
            john.AdditionMontant(50m);

            
            jean.SoustractionMontant(80m);
            jean.AfficherMontant();

            john.SoustractionMontant(80m);

           
         
            john.AfficherMontant();



        }
    }
}
