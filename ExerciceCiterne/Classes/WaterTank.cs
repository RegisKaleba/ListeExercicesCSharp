using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciceCiterne.Classes
{
    internal class WaterTank
    {
        public int PoidsAVide { get; set; }
        public int CapaciteTotale { get; set; }
        public int NiveauRemplissage { get;  set; }

       
        public static int VolumeTotal { get; private set; } = 0;

     
        public WaterTank(int poidsAVide, int capaciteTotale, int niveauInitial)
        {
            PoidsAVide = poidsAVide;
            CapaciteTotale = capaciteTotale;

            
            NiveauRemplissage = Math.Min(niveauInitial, capaciteTotale);
            VolumeTotal += NiveauRemplissage;
        }

        public int PoidsTotal => PoidsAVide + NiveauRemplissage;

        public int Remplir(int litres)
        {
            int espaceDisponible = CapaciteTotale - NiveauRemplissage;

            if (litres <= espaceDisponible)
            {
                NiveauRemplissage += litres;
                VolumeTotal += litres;
                return 0;
            }
            else
            {
                NiveauRemplissage = CapaciteTotale;
                VolumeTotal += espaceDisponible;
                return litres - espaceDisponible;
            }
        }

        public int Vider(int litres)
        {
            if (litres <= NiveauRemplissage)
            {
                NiveauRemplissage -= litres;
                VolumeTotal -= litres;
                return litres;
            }
            else
            {
                int eauRecuperee = NiveauRemplissage;
                VolumeTotal -= NiveauRemplissage;
                NiveauRemplissage = 0;
                return eauRecuperee;
            }
        }
    }
}
