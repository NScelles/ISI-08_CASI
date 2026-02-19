using Exercice_quatre.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_quatre.ExpboolComposite.entity.Operateur
{
    internal class ExpNon : Operateur
    {
        public ExpNon(Expbool expbool, Expbool? expboolDeux = null) : base(expbool, expboolDeux)
        {
        }


        public override bool evalue(Contexte contexte)
        {
            Console.WriteLine("Evaluation de l'operateur NON");
            return !expbool.evalue(contexte);
        }
    }
}
