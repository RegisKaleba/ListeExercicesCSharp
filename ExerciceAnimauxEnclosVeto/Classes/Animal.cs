/*
Classe Animal
Caractéristiques :

Name (string)
Species (string)
Energy (int, 0..100)
Méthodes :

Eat(int amount) : augmente Energy (max 100)
Play(int amount) : diminue Energy (min 0)
Describe() : retourne une string descriptive
*/


using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciceAnimauxEnclosVeto.Classes
{
    internal class Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }

        private int energy;
        public int Energy
        {
            get { return energy; }
            private set
            {
                if (value < 0) energy = 0;
                else if (value > 100) energy = 100;
                else energy = value;
            }
        }

        public Animal(string name, string species, int energy)
        {
            Name = name;
            Species = species;
            Energy = energy;
        }

        public void Eat(int amount)
        {
            Energy += amount;
        }

        public void Play(int amount)
        {
            Energy -= amount;
        }

        public string Describe()
        {
            return $"{Name} ({Species}) - Énergie : {Energy}/100";
        }
    }
}