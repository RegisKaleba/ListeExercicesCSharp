int[] suiteNombres = { 1, 2, 5, 7, 9 };

bool estCroissante = true;

for (int i = 1; i < suiteNombres.Length; i++)
{
    if (suiteNombres[i] <= suiteNombres[i - 1])
    {
        estCroissante = false;
        break;
    }
}

if (estCroissante)
{
    Console.WriteLine("La suite est croissante,tralala");
}
else
{
    Console.WriteLine("La suite n'est pas croissante, trululu");
}
