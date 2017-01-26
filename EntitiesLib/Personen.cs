using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntitiesLib
{
    public class Personen
    {
        public Personen()
        {
            PersonenLijst = new List<Persoon>();
        }

        [Key]
        public int Id { get; set; }

        public List<Persoon> PersonenLijst { get; }
    }
}
