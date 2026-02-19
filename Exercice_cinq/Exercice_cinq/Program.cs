using System;
using System.Collections.Generic;
using Exercice_cinq.entity;
using Exercice_cinq.Decoration;

List<CoupeGlaceeInterface> commandes = new List<CoupeGlaceeInterface>();
bool continuer = true;

while (continuer)
{
    Console.WriteLine("Quelle coupe glacée voulez-vous ?");
    Console.WriteLine("    1. Triple chocolat");
    Console.WriteLine("    2. Fruits rouges");
    Console.Write("Votre choix (1 ou 2) :\n");
    string? choix = Console.ReadLine();

    CoupeGlaceeInterface coupe = null;

    if (choix == "1")
    {
        coupe = new TripleChocolat(new List<Parfum>());
    }
    else if (choix == "2")
    {
        coupe = new FruitsRouges(new List<Parfum>());
    }

    if (coupe != null)
    {
        Console.WriteLine("Voulez-vous un supplément (o/n) ?");
        string? repSupplement = Console.ReadLine();
        
        while (repSupplement == "o")
        {
            Console.WriteLine("Quel supplément voulez-vous rajouter ?");
            Console.WriteLine("0. Aucun");
            Console.WriteLine("1. De la chantilly");
            Console.WriteLine("2. Un coulis de fraises fraîches");
            Console.WriteLine("3. Un nappage chocolat chaud");
            Console.Write("Votre choix : ");
            string? choixSupp = Console.ReadLine();

            if (choixSupp == "1")
            {
                coupe = new ChantillyDecoration(coupe);
            }
            else if (choixSupp == "2")
            {
                coupe = new CoulisFraiseDecoration(coupe);
            }
            else if (choixSupp == "3")
            {
                coupe = new SauceChocolat(coupe);
            }
            else if (choixSupp == "0")
            {
                break;
            }

            Console.WriteLine("Voulez-vous un autre supplément (o/n) ?");
            repSupplement = Console.ReadLine();
        }

        commandes.Add(coupe);
    }

    Console.WriteLine("Voulez-vous acheter une autre coupe glacée (o/n)");
    string? reponse = Console.ReadLine();
    if (reponse != "o")
    {
        continuer = false;
    }
}

Console.WriteLine();

double total = 0;
int numero = 1;

foreach (CoupeGlaceeInterface coupe in commandes)
{
    Console.WriteLine("*********************************");
    Console.WriteLine($"Coupe numéro {numero}");

    coupe.Description();
    Console.WriteLine();
    
    double prix = coupe.Prix();
    Console.WriteLine($"{prix} Euros");
    Console.WriteLine();

    total += prix;
    numero++;
}

Console.WriteLine($"POUR UN MONTANT TOTAL DE : {total} Euros");
