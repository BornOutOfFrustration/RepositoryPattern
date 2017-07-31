namespace RepositoryLayer
{
    public class PersoonRepository : Repository<EntitiesLib.Persoon>, IPersoonRepository
    {
        internal PersoonRepository(TheDbContext context) : base(context)
        {
        }

        private new TheDbContext Context
        { get { return base.Context as TheDbContext; } }

        // TODO: Add filtered query results.
    }
}
