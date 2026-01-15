using System;
using ExercicePOOPendu.Classes;
using ExercicePOOPendu.Pendu;

namespace ExercicePOOPendu.IHM
{
    internal class IHMConsole
    {
        private JeuPendu jeu;

        public void Lancer()
        {
            Console.WriteLine("=== Paramètres de la partie ===");

            int essais = DemanderNombreEssais();
            string mot = ObtenirMot();

            jeu = new JeuPendu(mot, essais);

            BoucleDeJeu();
            AfficherResultat();
        }

        private int DemanderNombreEssais()
        {
            Console.Write("Voulez-vous un nombre d'essais spécifique (10 par défaut) ? Y/N : ");
            string choix = Console.ReadLine().Trim().ToUpper();

            if (choix == "Y")
            {
                int essais;
                do
                {
                    Console.Write("Combien voulez-vous d'essais ? ");
                } while (!int.TryParse(Console.ReadLine(), out essais) || essais <= 0);

                return essais;
            }

            return 10;
        }

        private string ObtenirMot()
        {
            Console.Write("Voulez-vous entrer un mot vous-même ? (Y/N) : ");
            string choix = Console.ReadLine().Trim().ToUpper();

            if (choix == "Y")
                return DemanderMotUtilisateur();
            else
                return GenerateurMots.GenererMot();
        }

        private string DemanderMotUtilisateur()
        {
            string mot;
            bool motValide;

            do
            {
                Console.Write("Entrez le mot à faire deviner : ");
                mot = Console.ReadLine();

                motValide = true; 
                if (mot == "") 
                {
                    motValide = false;
                }
                else
                {
                    
                    foreach (char c in mot)
                    {
                        if (c == ' ') 
                        {
                            motValide = false;
                            break;
                        }
                    }
                }

            } while (!motValide); 

            Console.Clear(); 
            return mot.ToUpper();
        }

        private void BoucleDeJeu()
        {
            while (!jeu.TestWin() && !jeu.TestLose())
            {
                Console.WriteLine($"\nMot à trouver : {jeu.Masque}");
                Console.WriteLine($"Il vous reste {jeu.NombreEssais} essais");
                Console.Write("Veuillez saisir une lettre : ");

                char lettre = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                bool trouve = jeu.TestChar(lettre);

                if (trouve)
                    Console.WriteLine($"Bravo ! La lettre '{lettre}' est dans le mot.");
                else
                    Console.WriteLine($"Dommage ! La lettre '{lettre}' n'est pas dans le mot.");
            }
        }

        private void AfficherResultat()
        {
            if (jeu.TestWin())
                Console.WriteLine($"\n Bravo ! Vous êtes un Winner ! Le mot était : {jeu.MotATrouver}");
            else
                Console.WriteLine($"\n Perdu, turlututu, chapeau pointu... Le mot était : {jeu.MotATrouver}");
        }
    }
}
