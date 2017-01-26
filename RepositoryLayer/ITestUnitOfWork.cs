using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public interface ITestUnitOfWork : IDisposable
    {
        IPersoonRepository Personen { get; }
        IAdresRepository Adressen { get; }
        int Complete();
    }
}
