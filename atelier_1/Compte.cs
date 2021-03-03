using System;
using System.Collections.Generic;
using System.Text;

namespace Atelier_n1
{
    class Compte
    {
        public Compte(float sold_init,ref Personne cl)
        {
            this.solde = sold_init;
            this.num_compte = ++cpt_campte;
            this.client = cl;
        }
        public  void print_info()
        {
            Console.WriteLine("numero du compte : " + this.num_compte +" solde : "+this.solde);
        }
        public void print_info_user()
        {
            Console.WriteLine("numero du compte : " + this.num_compte + " solde : " + this.solde);
            this.client.print();
        }
        public void crediter(float val)
        {
            if (val > 0)
            {
                this.solde += val;
            }
        }
        public void Debiter(float val)
        {
            if (val > 0)
            {
                if (val < Compte.max_plafond)
                {
                    if (val < this.solde)
                    {
                        this.solde -= val;
                    }
                    else
                        Console.WriteLine("solde compte insuffisant!");
                }
                else
                    Console.WriteLine("Retrait superieur au plafond");
            }
        }
        public static void vairement( Compte P1de, Compte P2cr,float val)
        {
            P1de.Debiter(val);
            P2cr.crediter(val);

        }

        private float solde;
        private  Int32 num_compte;
        private static Int32 cpt_campte=0;
        private static float max_plafond = 20000;
        private Personne client;
    }
}
