namespace Exercice_un.Entities
{
    internal class Personne
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Batiment> Batiments { get; set; }
        public Personne() { }
    }
}