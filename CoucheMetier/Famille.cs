using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoucheMetier
{
    public class Famille
    {
        //Attributs
        private string id;
        private string libelle;
        //getter setter

        public string Id {  get; set; }
        public string Libelle {  get; set; }

        //Constructeur
        public Famille(string id, string libelle)
        {
            Id = id;
            Libelle = libelle;
        }
        
    }
}
