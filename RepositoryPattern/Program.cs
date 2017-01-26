namespace RepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new EntitiesLib.Persoon() { Achternaam = "geert", Voornaam = "jansen"};
            var p2 = new EntitiesLib.Persoon() { Achternaam = "person", Voornaam = "unknown" };
            
            using (RepositoryLayer.ITestUnitOfWork uow = new RepositoryLayer.UnitOfWorkFactory().Create())
            {
                uow.Personen.Add(p1);
                uow.Personen.Add(p2);
                uow.Complete();
            }
        }
    }
}
