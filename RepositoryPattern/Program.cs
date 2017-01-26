namespace RepositoryPattern
{
    using System.Data.Entity.SqlServer;
    using System.Data.SqlClient;

    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new EntitiesLib.Persoon() { Achternaam = "geert", Voornaam = "jansen" };
            var p2 = new EntitiesLib.Persoon() { Achternaam = "person", Voornaam = "unknown" };
            var a1 = new EntitiesLib.Adres() { Stad = "rotterdam", Straatnaam = "mijn straat" };
            a1.Inwoners.PersonenLijst.Add(p1);
            a1.Inwoners.PersonenLijst.Add(p2);
            using (RepositoryLayer.ITestUnitOfWork uow = new RepositoryLayer.TestUnitOfWork(new RepositoryLayer.TestDbContext()))
            {
                uow.Personen.Add(p1);
                uow.Personen.Add(p2);
                uow.Adressen.Add(a1);
                uow.Complete();
            }
        }
    }



    internal static class MissingDllHack
    {
        // Must reference a type in EntityFramework.SqlServer.dll so that this dll will be
        // included in the output folder of referencing projects without requiring a direct 
        // dependency on Entity Framework. See http://stackoverflow.com/a/22315164/1141360.
        private static SqlProviderServices instance = SqlProviderServices.Instance;
    }
}
