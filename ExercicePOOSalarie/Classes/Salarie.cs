/*
Créer une classe Salarié ayant pour attributs : le
matricule, le service, la catégorie, le nom et le salaire de
l’employé
2. Cette classe aura également comme méthode
AfficherSalaire()
3. Cette classe pourra, via deux champs et une méthode,
permettre de savoir le nombre total d’employés, le
salaire total et remettre à zéro la valeur du nombre
d’employés dans l’entreprise
4. Créer une IHM pour tester le fonctionnement de
l'application
*/


using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicePOOSalarie.Classes
{
    internal class Salarie
    {
        // Attributs
        public string Matricule { get; set; }
        public string Service { get; set; }
        public string Categorie { get; set; }
        public string Nom { get; set; }
        public double Salaire { get; set; }

      
        public static int NombreEmployes { get; set; }
        public static double SalaireTotal { get; set; }

     
        public Salarie(string matricule, string service, string categorie, string nom, double salaire)
        {
            Matricule = matricule;
            Service = service;
            Categorie = categorie;
            Nom = nom;
            Salaire = salaire;

            NombreEmployes++;
            SalaireTotal += salaire;
        }

      
        public string AfficherSalaire()
        {
            return $"Le salarié {Nom} a un salaire de {Salaire} thunes";
        }

        public static void ResetEntreprise()
        {
            NombreEmployes = 0;
            SalaireTotal = 0;
        }
    }
}




