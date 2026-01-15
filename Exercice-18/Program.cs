int[] notes = { 2, 12, 26, 9, 21, 3 };


for (int i = 0; i < notes.Length; i++)
{
    if (notes[i] < 10)
    {
        notes[i] = 10;
    }
    else if (notes[i] > 20)
    {
        notes[i] = 20;
    }
}

Console.WriteLine("Notes après modification :");
foreach (int note in notes)
{
    Console.Write(note + " ");
}

