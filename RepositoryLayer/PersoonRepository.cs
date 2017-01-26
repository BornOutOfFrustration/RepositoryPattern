using EntitiesLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace RepositoryLayer
{
    public class PersoonRepository : Repository<Persoon>, IPersoonRepository
    {
        internal PersoonRepository(TestDbContext context) : base(context)
        {
        }

        private new TestDbContext Context
        { get { return base.Context as TestDbContext; } }
    }
}
