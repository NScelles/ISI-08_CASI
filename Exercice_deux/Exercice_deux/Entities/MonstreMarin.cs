using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_deux.Entities
{
    internal class MonstreMarin : Monstre
    {
        public int TypeEau { get; set; }
        public List<Nageoire> Nageoires { get; set; }
        public MonstreMarin() { }

        public new MonstreMarin Clone()
        {
            MonstreMarin clone = (MonstreMarin)base.Clone();
            //clone.TypeEau = this.TypeEau;
            //clone.Nageoires = this.Nageoires; // Problème d'alias
            //clone.Yeux = this.Yeux; // Problème d'alias

            clone.Nageoires = new List<Nageoire>();
            foreach (Nageoire nageoire in Nageoires)
            {
                clone.Nageoires.Add(new Nageoire { Longueur = nageoire.Longueur, Type = nageoire.Type });
            }
            clone.Yeux = new List<Oeil>();
            foreach (Oeil oeil in Yeux)
            {
                clone.Yeux.Add(new Oeil { Couleur = oeil.Couleur, Diametre = oeil.Diametre });
            }
            return clone; 
        }
    }
}
