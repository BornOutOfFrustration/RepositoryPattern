namespace RepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new EntitiesLib.Persoon() { Voornaam = "jansen"};
            var p2 = new EntitiesLib.Persoon() { Voornaam = "unknown" };
            
            using (RepositoryLayer.ITestUnitOfWork uow = new RepositoryLayer.UnitOfWorkFactory().Create())
            {
                uow.Personen.Add(p1);
                uow.Personen.Add(p2);
                uow.Complete();
            }

            using (RepositoryLayer.ITestUnitOfWork uow = new RepositoryLayer.UnitOfWorkFactory().Create())
            {
                var p3 = uow.Personen.Get(1);
                var p = uow.Personen.GetAll();
            }
        }
    }
}
