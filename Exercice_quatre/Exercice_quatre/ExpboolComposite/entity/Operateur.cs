using Exercice_quatre.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_quatre.ExpboolComposite.entity.Operateur
{
    abstract class Operateur : Expbool
    {
        public Expbool expbool { get; set; }
        protected Expbool? expboolDeux;

        public Operateur(Expbool expbool, Expbool? expboolDeux = null)
        {
            this.expbool = expbool;
            this.expboolDeux = expboolDeux;
        }

        abstract public bool evalue(Contexte contexte);
    }
}
