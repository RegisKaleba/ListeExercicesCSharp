
using System;

namespace ExercicePOOPendu.Classes
{
    internal static class GenerateurMots
    {
        private static string[] mots =
        {
            "jambon", "amusant", "acordéon",
            "dinosaure", "pendu", "christophe", "developpeur"
        };

        private static Random rnd = new Random();

        public static string GenererMot()
        {
            return mots[rnd.Next(mots.Length)].ToUpper();
        }
    }
}
