using System;
using System.Collections.Generic;
using System.Text;

namespace Atelier_n1
{
    class Personne
    {
        public Personne(string nom,string pre,string adr)
        {
            this.nom = nom;
            this.prenom = pre;
            this.adresse = adr;
        }
        public void print()
        {
            Console.WriteLine("le nom :" + this.nom + " le prenom : " + this.prenom + " l'adresse " + this.adresse);
        }



        private string nom;
        private string prenom;
        private string adresse;
    }
}
