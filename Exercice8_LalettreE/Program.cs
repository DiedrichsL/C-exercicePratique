string phrase ="";
int i = 0;

Console.WriteLine("Entrez une phrase");
phrase = Console.ReadLine();

    for (i = 0; i < phrase.Length; i++) 
{ 

    if (phrase[i] == 'e' || phrase[i] == 'E' )
    {
     Console.WriteLine($"il y'a un E la position: {i+1} " );
    }
}


