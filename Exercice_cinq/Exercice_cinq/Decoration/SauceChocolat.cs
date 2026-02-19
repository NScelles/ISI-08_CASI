using Exercice_cinq.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_cinq.Decoration
{
    internal class SauceChocolat : SupplementDecorateur
     {
        public override string nom { get; set; } = "Sauce chocolat";
        public override double prix { get; set; } = 0.7;
        public SauceChocolat(CoupeGlaceeInterface coupeGlacee) : base(coupeGlacee)
        {
        }

        public override void Description()
        {
            base.Description();
            Console.Write(" avec supplément nappage chocolat");
        }

    }
}
