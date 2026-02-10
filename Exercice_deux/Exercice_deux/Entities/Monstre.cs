using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_deux.Entities
{
    internal class Monstre
    {
        public string Nom { get; set; }
        public List<Oeil> Yeux { get; set; }
        public Monstre() { }

        public Monstre Clone()
        {
            return (Monstre)MemberwiseClone();
        }
    }
}
