using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_un.Entities
{
    internal class Salle
    {

        public int ID { get; set; }
        public string Numero { get; set; }

        public List<Mur> Murs { get; set; }
        public Salle() { }
    }
}
