using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLib
{
    public class Adres
    {
        public Adres()
        {
            Inwoners = new Personen();
        }

        public string Straatnaam { get; set; }
        public string Stad { get; set; }

        public Personen Inwoners { get; }
    }
}
