using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicePOOSalarie.Classes
{
    internal class IHM
    {
        private List<Salarie> listeSalaries = new List<Salarie>();

        public void Demarrer()
        {
            bool quitter = false;

            while (!quitter)
            {
                Console.Clear();
                Console.WriteLine("=== GESTION DES SALARIÉS ===");
                Console.WriteLine("1 - Ajouter un salarié");
                Console.WriteLine("2 - Afficher informations");
                Console.WriteLine("3 - Réinitialiser l'entreprise");
                Console.WriteLine("4 - Quitter");
                Console.Write("Votre choix : ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Salarie nouveau = CreerSalarie();
                        listeSalaries.Add(nouveau);
                        Console.WriteLine("\nSalarié ajouté avec succès.");
                        Pause();
                        break;

                    case "2":
                        AfficherInfos();
                        Pause();
                        break;

                    case "3":
                        Salarie.ResetEntreprise();
                        Console.WriteLine("\nEntreprise réinitialisée.");
                        Pause();
                        break;

                    case "4":
                        quitter = true;
                        break;

                    default:
                        Console.WriteLine("\nChoix invalide.");
                        Pause();
                        break;
                }
            }
        }

        private Salarie CreerSalarie()
        {
            Console.Write("Matricule : ");
            string? matricule = Console.ReadLine();

            Console.Write("Service : ");
            string? service = Console.ReadLine();

            Console.Write("Catégorie : ");
            string? categorie = Console.ReadLine();

            Console.Write("Nom : ");
            string? nom = Console.ReadLine();

            Console.Write("Salaire : ");
            double salaire = double.Parse(Console.ReadLine());

            return new Salarie(matricule, service, categorie, nom, salaire);
        }

        private void AfficherInfos()
        {
            if (listeSalaries.Count == 0)
            {
                Console.WriteLine("\nAucun salarié enregistré.");
                return;
            }

            Console.WriteLine("\n=== Informations sur tous les salariés ===");
            foreach (Salarie s in listeSalaries)
            {
                Console.WriteLine(s.AfficherSalaire());
            }

            Console.WriteLine($"\nNombre total d'employés : {Salarie.NombreEmployes}");
            Console.WriteLine($"Salaire total : {Salarie.SalaireTotal} thunes");
        }

        private void Pause()
        {
            Console.WriteLine("\nAppuyez sur une touche pour continuer...");
            Console.ReadKey();
        }
    }
}