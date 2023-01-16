using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdusApp.Models
{
    public class BazaDedateProduse
    {
        public static List<Produs> ListaProduse()
        {
            List<Produs> produse = new List<Produs>()
            {
                new Produs
                {
                    ID = 1,
                    Nume = "Milka",
                    Pret = (decimal) 10.00
                },
                new Produs
                {
                    ID = 2,
                    Nume = "Schogetten",
                    Pret = (decimal) 15.00
                },
                new Produs
                {
                    ID = 3,
                    Nume = "Poiana",
                    Pret = (decimal) 20.00
                },
                new Produs
                {
                    ID = 4,
                    Nume = "Lindt",
                    Pret = (decimal) 25.00
                },
                new Produs
                {
                    ID = 5,
                    Nume = "Africana",
                    Pret = (decimal) 30.00
                }
                 
            };

            return produse;
        }

        public static Produs Articol(string articol)
        {
            List<Produs> produse = BazaDedateProduse.ListaProduse();

            foreach(Produs p in produse)
            {
                if(p.Nume == articol)
                {
                    return p;
                }
            }

            return null;
        }
    }
}
