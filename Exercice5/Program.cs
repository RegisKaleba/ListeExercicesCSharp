// See https://aka.ms/new-console-template for more information
int a;
int b;

string? operateur = null;

string? nombreA = null;
string? nombreB = null;

bool okA = int.TryParse(nombreA, out a);
bool okB = int.TryParse(nombreB, out b);

Console.WriteLine("saisir le premier entier");
nombreA = Console.ReadLine();
Console.WriteLine("donner un operateur ( + - * / )");
operateur = Console.ReadLine();
Console.WriteLine("saisir le deuxieme entier");
nombreB = Console.ReadLine();

if (!okA || !okB)
{
    Console.WriteLine("l'un des nombres est incorrect");
}