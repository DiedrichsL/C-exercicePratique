int X = 0;
int y = 0;
int pose = 0;

Console.WriteLine("Entrez une valeur pour X et pour Y");
X = int.Parse(Console.ReadLine());
y = int.Parse(Console.ReadLine());
Console.WriteLine($"Avant permutation: {X} et {y}");
pose = X;
X = y;
y = pose;
Console.WriteLine($"Après  permutation: {X} et {y}");