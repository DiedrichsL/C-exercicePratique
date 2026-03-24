int Annee = 0;
Console.WriteLine(" Quelle est votre année de naissance ? ");
Annee = int.Parse(Console.ReadLine());
int Age = 2026 - Annee;
Console.WriteLine($"Vous êtes dans l'année de vos {Age} ans");
