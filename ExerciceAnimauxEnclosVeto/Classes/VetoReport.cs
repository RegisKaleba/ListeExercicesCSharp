/*
Classe VetoReport
Caractéristiques (champs privés) :

animalName (string)
notes (string)
severity (int, 1..5)
Méthodes :

SetAnimalName(string) / GetAnimalName()
SetNotes(string) / GetNotes()
SetSeverity(int) / GetSeverity() (valide 1..5)
Print() : affiche le rapport
*/


using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciceAnimauxEnclosVeto.Classes
{
    internal class VetoReport
    {
        private string animalName;
        private string notes;
        private int severity;
        private bool severityValid = false; 

        public void SetAnimalName(string name)
        {
            animalName = name;
        }

        public string GetAnimalName()
        {
            return animalName;
        }

        public void SetNotes(string n)
        {
            notes = n;
        }

        public string GetNotes()
        {
            return notes;
        }

        public void SetSeverity(int s)
        {
            
            if (s >= 1 && s <= 5)
            {
                severity = s;
                severityValid = true;
            }
            else
            {
                severityValid = false; 
            }
        }

        public int GetSeverity()
        {
            if (!severityValid)
                throw new InvalidOperationException("Sévérité invalide");
            return severity;
        }

        public void Print()
        {
            Console.WriteLine($"Rapport vétérinaire pour {animalName}");
            Console.WriteLine($"Notes : {notes}");

            
            if (severityValid)
            {
                Console.WriteLine($"Sévérité : {severity}/5");
            }
            else
            {
                Console.WriteLine("Sévérité invalide (doit être entre 1 et 5)");
            }

            Console.WriteLine();
        }
    }
}