using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_cinq.entity
{
    internal class TripleChocolat : CoupeGlacee
    {
        public TripleChocolat(List<Parfum> parfums) : base(parfums)
        {
            parfums.Add(Parfum.CHOCOBLANC);
            parfums.Add(Parfum.CHOCONOIR);
            parfums.Add(Parfum.CHOCOLAIT);
        }

        public override double Prix()
        {
            return 3;
        }

        public override void Description()
        {
            Console.Write("Coupe triple chocolat parfums : ");
            base.Description();
        }
    }
}
