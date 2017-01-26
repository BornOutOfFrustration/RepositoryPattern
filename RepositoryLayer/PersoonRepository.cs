namespace RepositoryLayer
{
    public class PersoonRepository : Repository<EntitiesLib.Persoon>, IPersoonRepository
    {
        internal PersoonRepository(TestDbContext context) : base(context)
        {
        }

        private new TestDbContext Context
        { get { return base.Context as TestDbContext; } }

        // TODO: Add filtered query results.
    }
}
