// See https://aka.ms/new-console-template for more information


Console.WriteLine("Exercice 6");


        int a, b;
        string entier;


        Console.Write("Entrez le premier entier : ");
        entier = Console.ReadLine();
        if (!int.TryParse(entier, out a))
        {
            Console.WriteLine("Erreur : ce n'est pas un entier valide.");
            return;
        }
        
        Console.Write("Entrez un opérateur (+, -, *, /) : ");
        string operateur = Console.ReadLine();

        Console.Write("Entrez le second entier : ");
        entier = Console.ReadLine();
        if (!int.TryParse(entier, out b))
        {
            Console.WriteLine("Erreur : ce n'est pas un entier valide.");
            return;
        }


        switch (operateur)
        {
            case "+":
                Console.WriteLine($"{a} + {b} = {a + b}");
                break;
            case "-":
                Console.WriteLine($"{a} - {b} = {a - b}");
                break;
            case "*":
                Console.WriteLine($"{a} * {b} = {a * b}");
                break;
            case "/":
                if (b == 0)
                {
                    Console.WriteLine("Division impossible : division par 0");
                }
                else
                {
                    Console.WriteLine($"{a} / {b} = {(double)a / b}");
                }
                break;
            default:
                Console.WriteLine("Opérateur invalide");
                break;
        }
    
        