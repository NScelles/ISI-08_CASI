using Exercice_quatre.Entity;
using Exercice_quatre.ExpboolComposite.entity;
using Exercice_quatre.ExpboolComposite.entity.Operateur;

Expbool expression;

Contexte contexte = new Contexte();

Variable a = new Variable("a");
Variable b = new Variable("b");

expression = new ExpOu(new ExpEt(a, (new ExpNon(b))), new ExpEt(b, new Constante(true)));

contexte.assigner(a, true);
contexte.assigner(b, true);

Console.WriteLine(expression.evalue(contexte));