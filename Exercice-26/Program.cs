void AfficherTable(int nombre, int limite = 10)
{
    for (int i = 1; i <= limite; i++)
    {
        Console.WriteLine($"{nombre} x {i} = {nombre * i}");
    }
}

Console.Write("Entrez un nombre : ");
int nombre = int.Parse(Console.ReadLine());

AfficherTable(nombre);
