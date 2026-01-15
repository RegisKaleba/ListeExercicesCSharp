// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
Demander à l’utilisateur de saisir un mot. Parcourir chaque caractère du mot et compter le nombre de voyelles (a, e, i, o, u, y).

À la fin, afficher le nombre de voyelles trouvées.
*/

Console.Write("Entrez un mot : ");
string mot = Console.ReadLine().ToLower();

int compteurVoyelles = 0;

foreach (char c in mot)
    {
        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'y')
        {
            compteurVoyelles++;
        }
    }

Console.WriteLine("Nombre de voyelles : " + compteurVoyelles);