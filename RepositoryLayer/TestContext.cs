using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntitiesLib;

namespace RepositoryLayer
{
    public class TestDbContext : DbContext
    {
        public DbSet<Persoon> Personen { get; set; }
        public DbSet<Adres> Adressen { get; set; }
    }
}
