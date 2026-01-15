using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicePOOPendu.Pendu
{
    internal class JeuPendu
    {
 
            public string MotATrouver { get; private set; }
            public string Masque { get; private set; }
            public int NombreEssais { get; private set; }

           
            public JeuPendu(string mot, int essais = 10)
            {
                MotATrouver = mot.ToUpper();
                NombreEssais = essais;
                GenererMasque();
            }

          
            public void GenererMasque()
            {
                Masque = new string('*', MotATrouver.Length);
            }

     
        public bool TestChar(char c)
        {
            c = char.ToUpper(c);
            bool trouve = false;

            char[] nouveauMasque = Masque.ToCharArray();

            for (int i = 0; i < MotATrouver.Length; i++)
            {
                if (MotATrouver[i] == c)
                {
                    nouveauMasque[i] = c;
                    trouve = true;
                }
            }

            
            if (!trouve && !Masque.Contains(c))
                NombreEssais--;

            Masque = new string(nouveauMasque);

            return trouve;
        }

        
        public bool TestWin()
            {
                return !Masque.Contains("*");
            }

          
            public bool TestLose()
            {
                return NombreEssais <= 0;
            }
        

    }
}
