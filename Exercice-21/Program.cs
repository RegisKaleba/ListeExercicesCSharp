//Exercice-21

List<int> nombresPositifs = new List<int>();

int nombre;
bool estValide;

Console.WriteLine("Veuillez saisir 5 nombres :");

for (int i = 1; i <= 5; i++)
    {
        do
        {
            Console.Write("Nombre " + i + " : ");
            estValide = int.TryParse(Console.ReadLine(), out nombre);
        }
        while (!estValide);

        if (nombre > 0)
        {
            nombresPositifs.Add(nombre);
        }
    }

Console.WriteLine("\nNombres positifs saisis :");

foreach (int nombresSaisis in nombresPositifs)
    {
        Console.WriteLine(nombresSaisis);
    }