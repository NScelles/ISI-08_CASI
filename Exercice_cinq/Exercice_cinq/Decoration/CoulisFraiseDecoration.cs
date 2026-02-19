using Exercice_cinq.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_cinq.Decoration
{
    internal class CoulisFraiseDecoration : SupplementDecorateur
    {

        public override string nom { get; set; } = "Coulis de fraise";
        public override double prix { get; set; } = 1;

        public CoulisFraiseDecoration(CoupeGlaceeInterface coupeGlacee) : base(coupeGlacee)
        {
        }

        public override void Description()
        {
            base.Description();
            Console.Write(" avec son coulis de fraises fraîches");
        }
    }
}
