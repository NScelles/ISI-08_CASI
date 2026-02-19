using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_quatre.ExpboolComposite.entity
{
    class Contexte
    {
        public Dictionary<Variable, bool> variables { get; set; }
        public Contexte()
        {
            variables = new Dictionary<Variable, bool>();
        }

        public bool getValeur(Variable var)
        {
            return variables[var];
        }

        public void assigner(Variable var, bool val)
        {
            variables[var] = val;
        }

    }
}
