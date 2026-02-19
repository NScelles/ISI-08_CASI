using Exercice_cinq.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_cinq.Decoration
{
    abstract class SupplementDecorateur(CoupeGlaceeInterface coupeGlacee) : CoupeGlaceeInterface
    {
        protected readonly CoupeGlaceeInterface CoupeGlacee = coupeGlacee;
        public abstract string nom {get; set;}
        public abstract double prix {get; set; }

        public virtual void Description()
        {
            CoupeGlacee.Description();
        }

        public double Prix()
        {
            return prix + CoupeGlacee.Prix();
        }
    }
}
