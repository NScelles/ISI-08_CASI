using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_un.Entities
{
    internal class Batiment
    { 
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Salle> Salles { get; set; }
        public List<Mur> Murs { get; set; }
        public Personne personne { get; set; }

        public Batiment() 
        { 
            
        }

    }
}
