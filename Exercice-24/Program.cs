//Exercice-24

List<int> nombres = new List<int>();
int saisie = 0;

Console.WriteLine("Saisissez des nombres - Taper le nombre 0 met fin à la saisie :");

do
{
    Console.Write("Nombre : ");
    string input = Console.ReadLine();

    if (!int.TryParse(input, out saisie))
    {
        Console.WriteLine("Entrée invalide. Veuillez entrer un entier.");
        continue;
    }

    if (saisie != 0) 
    {
        nombres.Add(saisie);
    }

} while (saisie != 0);

bool estDecroissante = true;

for (int i = 1; i < nombres.Count; i++)
{
    if (nombres[i] >= nombres[i - 1]) 
    {
        estDecroissante = false;
        break; 
    }
}


if (estDecroissante && nombres.Count > 0)
{
    Console.WriteLine("La suite est strictement décroissante.");
}
else
{
    Console.WriteLine("La suite n'est pas strictement décroissante.");
}