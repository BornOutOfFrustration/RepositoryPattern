using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLib
{
    public class Personen
    {
        public Personen()
        {
            PersonenLijst = new List<Persoon>();
        }

        public List<Persoon> PersonenLijst { get; }
    }
}
