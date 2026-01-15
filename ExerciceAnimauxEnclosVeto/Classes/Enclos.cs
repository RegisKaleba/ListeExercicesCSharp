/*
Classe Enclos
Caractéristiques :

Name (string)
Capacity (int) avec validation : >= 1
Contient une liste d'Animal
Méthodes :

AddAnimal(Animal animal) : ajoute si place disponible
RemoveAnimal(string name) : retire un animal par nom, retourne true/false
GetAnimals() : retourne une copie de la liste
PrintStatus() : affiche l’état de l’enclos
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciceAnimauxEnclosVeto.Classes
{
    internal class Enclos
    {
        public string Name { get; set; }

        private int capacity; // champ privé

        public int Capacity
        {
            get { return capacity; }
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("L'enclos doit contenir au moins un animal");
                    return;
                }
                capacity = value; 
            }
        }

        private List<Animal> animals = new List<Animal>();

        public Enclos(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
        }

        public bool AddAnimal(Animal animal)
        {
            if (animals.Count >= Capacity)
                return false;

            animals.Add(animal);
            return true;
        }

        public bool RemoveAnimal(string name)
        {
            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i].Name == name)
                {
                    animals.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public List<Animal> GetAnimals()
        {
            return new List<Animal>(animals);
        }

        public void PrintStatus()
        {
            Console.WriteLine($"--- {Name} ---");
            Console.WriteLine($"Capacité : {animals.Count}/{Capacity}");

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Describe());
            }
        }
    }

}
