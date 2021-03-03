using System;

namespace Atelier_n1
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne Anasse = new Personne("Demnati", "Anasse", "Lot dhaini n9");
            Compte c1a = new Compte(200000,ref Anasse);
            Personne Houda = new Personne("Moutaki", "Houda", "casa");
            Compte c1H = new Compte(400000, ref Houda);
            c1a.print_info();
            c1H.print_info();
            Compte.vairement(c1a, c1H, 8000);
            c1a.print_info();
            c1H.print_info();
        }
    }
}
