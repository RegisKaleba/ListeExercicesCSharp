//Exercice-20

List<string> mots = new List<string>();
string saisie;

Console.WriteLine("Saisissez des mots (tapez \"stop\" pour terminer) :");

do
{
    saisie = Console.ReadLine();

    if (saisie.ToLower() != "stop")
    {
        mots.Add(saisie);
    }

} while (saisie.ToLower() != "stop");

Console.WriteLine("\nNombre total de mots saisis : " + mots.Count);

foreach (string mot in mots)
{
    Console.WriteLine(mot);
}
