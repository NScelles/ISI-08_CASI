using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_un.Entities
{
    internal class Universite
    {
        public int ID { get; set; }
        public List<Batiment> Batiments { get; set; }
        public List<Personne> Personnes { get; set; }
        public Universite() { }
    }
}
