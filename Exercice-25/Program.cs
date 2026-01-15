//Exercice-25

int[] notes = { 18, 15, 13, 10, 21, -2, 11 };

List<int> notesValides = new List<int>();

foreach (int note in notes)
{
    if (note >= 0 && note <= 20)
    {
        notesValides.Add(note);
    }
}

List<(int, string)> resultats = new List<(int, string)>();

foreach (int note in notesValides)
{
    string mention;

    if (note >= 16)
        mention = "Très bien";
    else if (note >= 14)
        mention = "Bien";
    else if (note >= 12)
        mention = "Assez bien";
    else
        mention = "Insuffisant";

    resultats.Add((note, mention));
}

Console.WriteLine("Note - Mention");
foreach (var tuple in resultats)
{
    Console.WriteLine($"{tuple.Item1} - {tuple.Item2}");
}
