using Exercice_quatre.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_quatre.ExpboolComposite.entity.Operateur
{
    internal class ExpOu : Operateur
    {
        public ExpOu(Expbool expbool, Expbool? expboolDeux = null) : base(expbool, expboolDeux)
        {
        }

        public override bool evalue(Contexte contexte)
        {
            Console.WriteLine("Evaluation de l'operateur OU");
            return expbool.evalue(contexte) || expboolDeux.evalue(contexte);
        }
    }
}
