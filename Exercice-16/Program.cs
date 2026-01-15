/*
Un tableau de taille 5 doit contenir des âges.

Le programme doit :

Demander à l’utilisateur de saisir 5 âges.
Refuser toute valeur négative ou supérieure à 120.
Stocker uniquement les valeurs valides dans le tableau.
Afficher à la fin :

le tableau complet
le nombre d’âges invalides saisis
*/

int[] ages = new int[5];
int index = 0;
int invalides = 0;

while (index < ages.Length)
{
    Console.Write("Entrez un âge : ");
    int age = int.Parse(Console.ReadLine());

    if (age >= 0 && age <= 120)
    {
        ages[index] = age;
        index++;
    }
    else
    {
        Console.WriteLine("Âge invalide !");
        invalides++;
    }
}

Console.WriteLine("Contenu du tableau :");
foreach (int age in ages)
{
    Console.WriteLine(age);
}

Console.WriteLine($"Nombre d’âges invalides saisis : {invalides}");


