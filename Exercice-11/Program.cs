// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
 En C#
Le programme choisit un nombre fixe (par exemple 7). L’utilisateur doit deviner ce nombre.
Tant que l’utilisateur n’a pas trouvé le bon nombre, le programme redemande une saisie.
Quand le nombre est trouvé, afficher Bravo, nombre trouvé !.
*/
int nombreSecret = 7;
int saisie = 0;
Console.Write("Devinez le nombre : ");

while (saisie != nombreSecret)
    {
    saisie = int.Parse(Console.ReadLine());

        if (saisie != nombreSecret)
            {
                Console.Write("Ce n'est pas le bon nombre, réessayez : ");
            }
    }
Console.WriteLine("Bravo, nombre trouvé !");
   

