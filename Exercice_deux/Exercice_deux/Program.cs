using Exercice_deux.Entities;
using System.Drawing;

internal class Program
{
        public static unsafe void Main(string[] args)
        {
            List<Nageoire> nageoires = new List<Nageoire> { new Nageoire { Type = TypeNageoire.Caudale, Longueur = 50 } };
            List<Oeil> yeux = new List<Oeil> { new Oeil { Couleur = Color.Red, Diametre = 10 } };
            MonstreMarin monstreMarin1 = new MonstreMarin { Nom = "ZirVak", TypeEau = 2, Nageoires = nageoires, Yeux = yeux };
            // On veut créer un deuxième monstre, identique au premier mais sans créer de problème d'alias
            MonstreMarin monstreMarin2 = monstreMarin1.Clone();
            // Affichons les deux monstres
            Afficher(monstreMarin1, monstreMarin2);

            Console.WriteLine("");
            Console.WriteLine("");
            // Modifions le second monstre pour vérifier que les deux monstres sont bien distincts
            monstreMarin2.Nom = "Nestor";
            monstreMarin2.Yeux[0].Couleur = Color.Gold;
            monstreMarin2.Yeux[0].Diametre = 50;
            monstreMarin2.TypeEau = 1;
            monstreMarin2.Nageoires[0].Type = TypeNageoire.Dorsale;
            monstreMarin2.Nageoires[0].Longueur = 100;
            Afficher(monstreMarin1, monstreMarin2);
    }

        private static void Afficher(MonstreMarin m1, MonstreMarin m2)
        {
            Console.WriteLine("\t\t\tmonstreMarin1\tmonstreMarin2");
            Console.WriteLine("__ Attributs de Monstre");
            Console.WriteLine("Nom\t\t\t" + m1.Nom + "\t\t" + m2.Nom);
            Console.WriteLine("** Oeil");
            Console.WriteLine("Couleur Oeil\t\t" + m1.Yeux[0].Couleur + "\t" + m2.Yeux[0].Couleur);
            Console.WriteLine("Diamètre Oeil\t\t" + m1.Yeux[0].Diametre + "\t\t" + m2.Yeux[0].Diametre);
            Console.WriteLine("__ Attributs de Monstre marin");
            Console.WriteLine("TypeEau\t\t\t" + m1.TypeEau + "\t\t" + m2.TypeEau);
            Console.WriteLine("** Nageoire");
            Console.WriteLine("Longueur Nageoire\t" + m1.Nageoires[0].Longueur + "\t\t" + m2.Nageoires[0].Longueur);
            Console.WriteLine("Type Nageoire\t\t" + m1.Nageoires[0].Type + "\t\t" + m2.Nageoires[0].Type);

        }

}