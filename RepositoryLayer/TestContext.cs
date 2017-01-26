
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace RepositoryLayer
{
    public class TestDbContext : DbContext
    {
        public DbSet<EntitiesLib.Persoon> Personen { get; set; }

        public TestDbContext()
        {
            // NuGet magic :-(
            // http://robsneuron.blogspot.nl/2013/11/entity-framework-upgrade-to-6.html

            // ROLA - This is a hack to ensure that Entity Framework SQL Provider is copied across to the output folder.
            // As it is installed in the GAC, Copy Local does not work. It is required for probing.
            // Fixed "Provider not loaded" error
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Entity Framework Fluent API
            // https://msdn.microsoft.com/en-us/data/jj591620.aspx
            
            // Configure Code First to ignore PluralizingTableName convention 
            // If you keep this convention then the generated tables will have pluralized names. 
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<EntitiesLib.Persoon>().ToTable(tableName: "Personen")
                .HasKey(t => t.Id);
        }
    }
}
