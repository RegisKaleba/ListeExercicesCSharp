/*
Programme principal (Program.cs)
Créer un Enclos "Enclos Nord" de capacité 2
Créer 3 animaux : Luna (Chat, 80), Rex (Chien, 50), Milo (Lapin, 30)
Ajouter 2 animaux, puis tenter d’ajouter le 3e (doit échouer proprement)
Appeler : Luna.Play(40) et Rex.Eat(60)
Afficher l’état de l’enclos
Créer 2 rapports vétérinaires et les afficher :

Luna : “Fatigue après jeu”, sévérité 2
Rex : “Très bonne forme”, sévérité 1
Tester une sévérité invalide (ex. 7) et vérifier le comportement
*/

using ExerciceAnimauxEnclosVeto;
using ExerciceAnimauxEnclosVeto.Classes;
using System;

Enclos enclos = new Enclos("Enclos Nord", 2);
Enclos enclos1 = new Enclos("Enclos Vis", 0);

Animal luna = new Animal("Luna", "Chat", 80);
Animal rex = new Animal("Rex", "Chien", 50);
Animal milo = new Animal("Milo", "Lapin", 30);

enclos.AddAnimal(luna);
enclos.AddAnimal(rex);

if (!enclos.AddAnimal(milo))
    Console.WriteLine("Impossible d'ajouter Milo : enclos plein");

luna.Play(40);
rex.Eat(60);

enclos.PrintStatus();
Console.WriteLine();

VetoReport report1 = new VetoReport();
report1.SetAnimalName("Luna");
report1.SetNotes("Fatigue après jeu");
report1.SetSeverity(2);
report1.Print();

Console.WriteLine();

VetoReport report2 = new VetoReport();
report2.SetAnimalName("Rex");
report2.SetNotes("Très bonne forme");
report2.SetSeverity(7); 
report2.Print();