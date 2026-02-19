using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_cinq.entity
{
    abstract class CoupeGlacee : CoupeGlaceeInterface
    {
        public List<Parfum> parfums { get; set; }

        public CoupeGlacee(List<Parfum> parfums)
        {
            this.parfums = parfums;
        }

        abstract public double Prix();

        public virtual void Description()
        {
            foreach (Parfum parfum in parfums)
            {
               Console.Write(parfum.ToString() + " - ");
            }
        }
    }
}
