// See https://aka.ms/new-console-template for more information
//
Console.WriteLine("Exercice 8!");


Console.Write("Entrez un entier : ");
string entier = Console.ReadLine();
int n;
if (int.TryParse(entier, out n))
{

    if (n < 0)
    {
        Console.WriteLine("Le nombre est négatif.");
    }
    else
    {
        if (n == 0)
        {
            Console.WriteLine("Le nombre est nul.");
        }
        else
        {
            Console.WriteLine("Le nombre est positif.");
        }
    }

    if (n % 2 == 0)
    {
        Console.WriteLine("Le nombre est pair.");
    }
    else
    {
        Console.WriteLine("Le nombre est impair.");
    }

    // Partie 3 : intervalle [-10;10] ou hors
    if (n >= -10 && n <= 10)
    {
        Console.WriteLine("Dans la fourchette [-10;10].");
    }
    else
    {
        Console.WriteLine("Hors de la fourchette [-10;10].");
    }
}
else
{
    Console.WriteLine("Entier invalide.");
}