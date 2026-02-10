using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_un.Entities
{
    internal class Mur
    {
        public int ID { get; set; }
        public List<Salle> Salles { get; set; }
        public Mur() { }
    }
}
