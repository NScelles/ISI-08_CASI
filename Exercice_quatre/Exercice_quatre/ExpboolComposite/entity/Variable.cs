using Exercice_quatre.Entity;

using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_quatre.ExpboolComposite.entity
{
    class Variable : Expbool
    {
        public string nom { get; set; }

        public Variable(string nom) { 
            this.nom = nom;
        }
        public bool evalue(Contexte contexte)
        {
            Console.WriteLine("Variable " + nom + " = " + contexte.getValeur(this));
            return contexte.getValeur(this);
        }
    }
}
