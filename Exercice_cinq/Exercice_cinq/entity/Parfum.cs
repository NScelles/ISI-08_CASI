using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_cinq.entity
{
    class Parfum
    {
        private string nomParfum;

        public static Parfum CHOCOBLANC = new Parfum("Chocolat blanc");
        public static Parfum CHOCONOIR = new Parfum("Chocolat noir");
        public static Parfum CHOCOLAIT = new Parfum("Chocolat au lait");
        public static Parfum FRAISE = new Parfum("Fraise");
        public static Parfum FRAMBOISE = new Parfum("Framboise");
        public static Parfum CASSIS = new Parfum("Cassis");

        private Parfum(string nomParfum)
        {
            this.nomParfum = nomParfum;
        }

        public string ToString()
        {
            return nomParfum;
        }

    }
}
