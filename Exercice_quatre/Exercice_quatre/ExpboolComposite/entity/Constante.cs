using Exercice_quatre.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_quatre.ExpboolComposite.entity
{
    internal class Constante : Expbool
    {
        public bool valeur { get; set; }
        public Constante(bool val) 
        {
            valeur = val;
        }
        public bool evalue(Contexte contexte)
        {
            Console.WriteLine("Constante : " + valeur);
            return valeur;
        }
    }
}
