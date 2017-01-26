using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RepositoryLayer.TestContext context = new RepositoryLayer.TestContext();
            var p1 = new EntitiesLib.Persoon() { Achternaam = "geert", Voornaam = "jansen" };
            var p2 = new EntitiesLib.Persoon() { Achternaam = "person", Voornaam = "unknown" };

            context.Personen.Add(p1);
            context.Personen.Add(p2);

            var a1 = new EntitiesLib.Adres() { Stad = "rotterdam", Straatnaam = "mijn straat" };
            a1.Inwoners.PersonenLijst.Add(p1);
            a1.Inwoners.PersonenLijst.Add(p2);
            context.Adressen.Add(a1);
            context.SaveChanges();
        }
    }
}
