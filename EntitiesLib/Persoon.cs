using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntitiesLib
{
    public class Persoon
    {
        [Key]
        public int Id { get; set; }

        public string Voornaam { get; set; }

        public string Achternaam { get; set; }
    }
}
