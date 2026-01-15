// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
 En C#
Demander à l’utilisateur de saisir un entier. Afficher la table de multiplication de cet entier de 1 à 10 à l’aide d’une boucle for.
*/

Console.Write("Entrez un nombre entier : ");
int nombre = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{nombre} x {i} = {nombre * i}");
    }