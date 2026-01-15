using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicePOOChaise.Classes
{
    internal class Chaise
    {
        private int nombreDePieds;
        private string materiau;
        private string couleur;

        public Chaise()
        {
            nombreDePieds = 4;
            materiau = "Bois";
            couleur = "Marron";
        }
        public Chaise(int nombreDePieds, string materiau, string couleur)
        {
            this.nombreDePieds = nombreDePieds;
            this.materiau = materiau;
            this.couleur = couleur;
        }

      
        public void AfficherInfos()
        {
            Console.WriteLine(ToString());
        }
        public override string ToString()
        {
            return $"Chaise : {this.nombreDePieds} pieds, matériau = {this.materiau}, couleur = {this.couleur}";
        }
    }
}
