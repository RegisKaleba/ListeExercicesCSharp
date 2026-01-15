// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercice7");

Console.Write("Veuillez indiquer une note entre 0 et 20 : ");
string input = Console.ReadLine();
bool isValid = int.TryParse(input, out int note);

if (!isValid || note < 0 || note > 20)
{
    Console.WriteLine("Note invalide");
}
else
{
    string appreciation = note
    switch
    {
        >=
        18 and <= 20 => "Excellent",
        >=
          15 and <= 17 => "Très bien",
        >=
          12 and <= 14 => "Bien",
        >=
          10 and <= 11 => "Passable",
        >=
          0 and <= 9 => "Insuffisant",
        _ => "Note invalide"
    };

    Console.WriteLine($"Vous avez été noté {note}/20. C'est {appreciation}.");
}
