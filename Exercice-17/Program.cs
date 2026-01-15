//Exercice-17

/*
Un tableau d’entiers est donné.

Le programme doit déterminer si deux valeurs consécutives identiques existent dans le tableau.

Si oui, afficher un message indiquant qu’une répétition a été trouvée.
Sinon, afficher un message indiquant qu’aucune répétition n’existe.
*/

int[] valeurs = { 12, 2, 8, 9, 6 };

bool repetition = false;

for (int i = 0; i < valeurs.Length -1; i++)
{
    if (valeurs[i] == valeurs[i + 1])
    {
        repetition = true;
        break;
    }
}

if (repetition)
{
    Console.WriteLine("Une répétition consécutive détectée !");
}
else
{
    Console.WriteLine("Aucune répétition consécutive détectée !");
}