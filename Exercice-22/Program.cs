//Exercice-22

List<int> temperatures = new List<int>();
int invalidCount = 0;
int temperature; 

Console.WriteLine("Entrez des températures (entre -50 et 50). Tapez -999 pour arrêter.");

do
{
    Console.Write("Température : ");
    string input = Console.ReadLine();

    if (!int.TryParse(input, out temperature))
    {
        Console.WriteLine("Entrée invalide. Veuillez entrer un nombre entier.");
        invalidCount++;
        temperature = 0;
        continue;
    }

    if (temperature >= -50 && temperature <= 50)
    {
        temperatures.Add(temperature);
    }
    else if (temperature != -999)
    {
        Console.WriteLine("Température hors limites.");
        invalidCount++;
    }

} while (temperature != -999);

Console.WriteLine("\nOn fait le bilan, calmement ");
Console.WriteLine($"Nombre de valeurs valides : {temperatures.Count}");
Console.WriteLine($"Nombre de valeurs invalides : {invalidCount}");

if (temperatures.Count > 0)
{
    int temperatureMinimum = temperatures[0];
    int temperatureMaximum = temperatures[0];

    foreach (int t in temperatures)
    {
        if (t < temperatureMinimum) temperatureMinimum = t;
        if (t > temperatureMaximum) temperatureMaximum = t;
    }

    Console.WriteLine($"Température minimale : {temperatureMinimum}");
    Console.WriteLine($"Température maximale : {temperatureMaximum}");
}
else
{
    Console.WriteLine("Aucune température valide saisie.");
}