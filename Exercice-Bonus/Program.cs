Console.Write("Entrez un mot : ");
string mot = Console.ReadLine();

Console.Write("Entrez les caractères à ignorer : ");
string caracteresIgnores = Console.ReadLine();

Console.Write("Entrez le caractère de fin : ");
char caractereFin = Console.ReadLine()[0];

foreach (char c in mot)
{

    if (c == caractereFin)
    {
        break;
    }

  
    if (caracteresIgnores.Contains(c))
    {
        continue;
    }

  
    Console.Write(c);
}