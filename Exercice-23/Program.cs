// Exercice-23

int[] scores = { 4, 8, 15, 16, 23, 42 };

Console.WriteLine("Affichez les scores :");
foreach (int s in scores)
{
    Console.Write(s + " ");
}
Console.WriteLine();

List<int> pairs = new List<int>();
List<int> impairs = new List<int>();

foreach (int score in scores)
{
    if (score % 2 == 0)
    {
        pairs.Add(score);
    }
    else
    {
        impairs.Add(score);
    }
}

Console.WriteLine("\nScores pairs :");
foreach (int p in pairs)
{
    Console.WriteLine(p + " ");
}

Console.WriteLine("\nScores impairs :");
foreach (int i in impairs)
{
    Console.WriteLine(i + " ");
}

    