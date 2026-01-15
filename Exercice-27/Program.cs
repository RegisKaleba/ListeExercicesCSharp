//Exercice+27
string DecrireNombre(int nombre)
{
    if (nombre < 0)
    {
        return "négatif";
    }
    else if (nombre == 0)
    {
        return "nul";
    }
    else
    {
        return "positif";
    }
}

Console.Write("Entrez un nombre : ");
int nombre = int.Parse(Console.ReadLine());

string resultat = DecrireNombre(nombre);
Console.WriteLine($"Le nombre est {resultat}.");
