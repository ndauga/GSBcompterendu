using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoucheMetier
{
    public class Medicament
    {

        //Attributs
        public string Composition { get; set; }
        public string ContreIndications {  get; set; }
        public string Effets { get; set; }
        public string Id { get; set; }
        public string NomCommercial { get; set; }
        public Famille LaFamille { get; set; }

        //Constructeur
        public Medicament(string composition, string contreIndications, string effets, string id, string nomCommercial)
        {
            Composition = composition;
            ContreIndications = contreIndications;
            Effets = effets;
            Id = id;
            NomCommercial = nomCommercial;
        }
        public Medicament(string composition, string contreIndications, string effets, string id, string nomCommercial, Famille famille)
        {
            Composition = composition;
            ContreIndications = contreIndications;
            Effets = effets;
            Id = id;
            NomCommercial = nomCommercial;
            LaFamille = famille;
        }

        public override string ToString()
        {
            return base.ToString() + " " + Id;
        }
    }
}
