using System;
using System.Collections.Generic;
using ExerciceCiterne.Classes;

namespace ExerciceCiterne
{
    public class IHM
    {
        private List<WaterTank> citernes = new List<WaterTank>();

        public void Lancer()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Gestion de citernes d'eau ===");
                Console.WriteLine("1 - Créer une nouvelle citerne");
                Console.WriteLine("2 - Remplir une citerne");
                Console.WriteLine("3 - Vider une citerne");
                Console.WriteLine("4 - Afficher les informations des citernes");
                Console.WriteLine("5 - Quitter");
                Console.Write("Choix : ");

                string choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        CreerCiterne();
                        break;
                    case "2":
                        RemplirCiterne();
                        break;
                    case "3":
                        ViderCiterne();
                        break;
                    case "4":
                        AfficherCiternes();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Choix invalide. Appuyez sur une touche.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private void CreerCiterne()
        {
            Console.Clear();
            Console.WriteLine("Création d'une nouvelle citerne");

            int poidsAVide = LireEntier("Poids à vide (kg) : ");
            int capaciteTotale = LireEntier("Capacité totale (litres) : ");
            int niveauInitial = LireEntier("Niveau initial (litres) : ");

            WaterTank citerne = new WaterTank(poidsAVide, capaciteTotale, niveauInitial);
            citernes.Add(citerne);

            Console.WriteLine("Citerne créée avec succès !");
            Console.ReadKey();
        }

        private void RemplirCiterne()
        {
            if (citernes.Count == 0)
            {
                Console.WriteLine("Aucune citerne disponible.");
                Console.ReadKey();
                return;
            }

            Console.Clear();
            Console.WriteLine("Remplir une citerne");

            int index = ChoisirCiterne();
            if (index == -1) return;

            int litres = LireEntier("Quantité d'eau à ajouter (litres) : ");
            int excedent = citernes[index].Remplir(litres);

            Console.WriteLine($"Excès d'eau non utilisé : {excedent} litres.");
            Console.ReadKey();
        }

        private void ViderCiterne()
        {
            if (citernes.Count == 0)
            {
                Console.WriteLine("Aucune citerne disponible.");
                Console.ReadKey();
                return;
            }

            Console.Clear();
            Console.WriteLine("Vider une citerne");

            int index = ChoisirCiterne();
            if (index == -1) return;

            int litres = LireEntier("Quantité d'eau à retirer (litres) : ");
            int recupere = citernes[index].Vider(litres);

            Console.WriteLine($"Eau récupérée : {recupere} litres.");
            Console.ReadKey();
        }

        private void AfficherCiternes()
        {
            Console.Clear();
            Console.WriteLine("Informations des citernes :");

            if (citernes.Count == 0)
            {
                Console.WriteLine("Aucune citerne créée.");
            }
            else
            {
                for (int i = 0; i < citernes.Count; i++)
                {
                    var c = citernes[i];
                    Console.WriteLine(
                        $"[{i}] Poids à vide : {c.PoidsAVide} kg, " +
                        $"Capacité : {c.CapaciteTotale} L, " +
                        $"Niveau : {c.NiveauRemplissage} L, " +
                        $"Poids total : {c.PoidsTotal} kg"
                    );
                }

                Console.WriteLine(
                    $"Volume total d'eau : {WaterTank.VolumeTotal} litres."
                );
            }

            Console.ReadKey();
        }

        private int ChoisirCiterne()
        {
            while (true)
            {
                Console.WriteLine("Liste des citernes :");
                for (int i = 0; i < citernes.Count; i++)
                {
                    var c = citernes[i];
                    Console.WriteLine($"[{i}] Capacité : {c.CapaciteTotale} L, Niveau : {c.NiveauRemplissage} L");
                }

                Console.Write("Numéro de la citerne : ");

                if (int.TryParse(Console.ReadLine(), out int index)
                    && index >= 0
                    && index < citernes.Count)
                {
                    return index;
                }

                Console.WriteLine("Sélection invalide. Réessayez.");
            }
        }

        private int LireEntier(string message)
        {
            int valeur;
            do
            {
                Console.Write(message);
            }
            while (!int.TryParse(Console.ReadLine(), out valeur) || valeur < 0);

            return valeur;
        }
    }
}
