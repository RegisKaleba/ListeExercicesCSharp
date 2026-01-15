/*
Un programme dispose d’un tableau d’entiers représentant des valeurs mesurées par un capteur.

Certaines valeurs peuvent être aberrantes (négatives).
Une valeur aberrante doit être ignorée.
Écrire un programme qui :

Parcourt le tableau.
Ignore les valeurs négatives.
Calcule et affiche :

le nombre de valeurs valides
la somme des valeurs valides
la moyenne des valeurs valides (si possible)
*/

int[] mesures = { 12, -5, 8, 0, -3, 15, 7, 8, 15, -32 };
int nombreValides = 0;
int somme = 0;

foreach (int valeur in mesures)
    {
    if (valeur >= 0)
        {
            nombreValides++;
            somme += valeur;
        }
    }

Console.WriteLine("Nombre de valeurs valides : " + nombreValides);
Console.WriteLine("Somme des valeurs valides : " + somme);

    if (nombreValides > 0)
        {
            double moyenne = (double)somme / nombreValides;
            Console.WriteLine("Moyenne des valeurs valides : " + moyenne);
        }
    else
        {
            Console.WriteLine("Moyenne impossible (aucune valeur valide).");
        }
    
