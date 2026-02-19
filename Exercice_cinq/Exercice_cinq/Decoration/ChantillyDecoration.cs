using Exercice_cinq.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_cinq.Decoration
{
    internal class ChantillyDecoration : SupplementDecorateur
    {

        public override string nom { get; set; } = "Chantilly";
        public override double prix { get; set; } = 0.5;
        public ChantillyDecoration(CoupeGlaceeInterface coupeGlacee) : base(coupeGlacee)
        {
        }

        public override void Description()
        {
            base.Description();
            Console.Write(" avec supplément chantilly");
        }
    }
}
