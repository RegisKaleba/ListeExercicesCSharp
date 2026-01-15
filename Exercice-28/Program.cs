//Exercice-28

int CompterPairs(List<int> nombres)
{
    int compteur = 0;

    foreach (int nombre in nombres)
    {
        if (nombre % 2 == 0)
        {
            compteur++;
        }
    }

    return compteur;
}

List<int> liste = new List<int> { 1, 2, 3, 4, 5, 6, 8 , 9, 10};

int nbPairs = CompterPairs(liste);

Console.WriteLine($"Nombre de valeurs paires : {nbPairs}");
