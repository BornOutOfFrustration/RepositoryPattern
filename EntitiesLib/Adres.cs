using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLib
{
    using System.ComponentModel.DataAnnotations;

    public class Adres
    {
        [Key]
        public int Id { get; set; }

        public Adres()
        {
            Inwoners = new Personen();
        }

        public string Straatnaam { get; set; }
        public string Stad { get; set; }

        public Personen Inwoners { get; set; }
    }
}
