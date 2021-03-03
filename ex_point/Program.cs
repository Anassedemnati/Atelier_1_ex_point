using System;
using first_touch_cs.G2;

namespace first_touch_cs
{
    class Program //c# c est un langage 
    {
        static void Main(string[] args)
        {
            string s = "30";
            int a = int.Parse(s);
            Console.WriteLine("bonjour G22"+a.ToString());
            point P1 = new point(3, 5);
            point P2 = new point(4, 20);

            P1.print();
            P2.print();
            P1.deplacer(7, 10);
            P1.print();
            
                Console.Write("la distance entre P1 et P2 = ");
            Console.WriteLine(P1.Dist(ref P2));
            point M = new point(0, 0);
            M = P1.pointmilieux(ref P2);
            M.print();









            Console.ReadKey();//console holde put it in the end


        }
    }
}
