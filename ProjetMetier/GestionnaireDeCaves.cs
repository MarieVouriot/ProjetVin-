using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetMetier
{
    public class GestionnaireDeCaves
    {
        private Dictionary<string, List<Bouteille>> lesCaves;

        public GestionnaireDeCaves()
        {
            LesCaves = new Dictionary<string, List<Bouteille>>();
        }

        public Dictionary<string, List<Bouteille>> LesCaves { get => lesCaves; set => lesCaves = value; }

        public void AjouterCave(string unNomDeCave,List<Bouteille> lesBouteillesDeLaCave)
        {
            LesCaves.Add(unNomDeCave, lesBouteillesDeLaCave);
        }

        public int NbBouteilles(string unNomDeCave)
        {
            int nbBouteille = 0;
            
            foreach(Bouteille bou in LesCaves[unNomDeCave])
            {
                nbBouteille += 1;
            }
            return nbBouteille;
        }

        public int NbBouteillesDeRouges(string unNomDeCave)
        {
            int nbBouteilleRouge = 0;
            foreach(Bouteille bou in LesCaves[unNomDeCave])
            {
                if(bou.LeVin.LaCouleur.NomCouleur == "rouge")
                {
                    nbBouteilleRouge += 1;
                }
            }
            return nbBouteilleRouge;
        }

        public double ValeurDeLaCave(string unNomDeCave)
        {
            double valeurCave = 0;

            foreach(Bouteille bou in LesCaves[unNomDeCave])
            {
                valeurCave = valeurCave + (bou.QuantiteBouteille * bou.LeVin.PrixDuVin);
            }

            return valeurCave;
        }
    }
}
