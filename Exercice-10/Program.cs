// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
Demander à l’utilisateur de saisir un entier strictement positif. Tant que l’utilisateur ne saisit pas un entier valide (> 0), redemander la saisie.

Une fois la valeur valide saisie, afficher tous les nombres de 1 jusqu’à ce nombre, un par ligne, à l’aide d’une boucle while.
*/

int nombre = 0;
while (nombre <= 0)
    {
        Console.Write("Veuillez saisir un entier strictement positif : ");
        string saisie = Console.ReadLine();

        if (!int.TryParse(saisie, out nombre) || nombre <= 0)
        {
        Console.WriteLine("Entrée invalide.");
        nombre = 0;
        }
    }
int i = 1;
while (i <= nombre)
    {
    Console.WriteLine(i);
    i++;
    }