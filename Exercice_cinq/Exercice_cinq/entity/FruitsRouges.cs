using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_cinq.entity
{
    internal class FruitsRouges : CoupeGlacee
    {
        public FruitsRouges(List<Parfum> parfums) : base(parfums)
        {
            parfums.Add(Parfum.FRAISE);
            parfums.Add(Parfum.FRAMBOISE);
            parfums.Add(Parfum.CASSIS);
        }

        public override double Prix()
        {
            return 5.5;
        }

        public override void Description()
        {
            Console.Write("Coupe fruits rouges parfums : ");
            base.Description();
        }
    }
}
