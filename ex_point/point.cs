using System;
using System.Collections.Generic;
using System.Text;


namespace first_touch_cs
{
    namespace G2 { 
    class point
    {
            public point(float x,float y)
            {
                this.x = x;
                this.y = y;
            }
            public void print()
            {
                Console.WriteLine("(" + this.x + "," + this.y + ")");
            }
            public void deplacer(float x,float y)
            {
                this.x = x;
                this.y = y;
            }
            public double Dist(ref point p1)
            {
                double res= Math.Sqrt((Math.Pow(this.x-p1.x,2))+ (Math.Pow(this.y - p1.y, 2)));
                

                return res;
            
            
            }
            public point pointmilieux(ref point p1)
            {
                point m = new point(0,0);
                m.x = (this.x + p1.x) / 2;
                m.y = (this.y + p1.y) / 2;
                return m;
            
            
            }



           private float x;
           private float y;


    }
   }
}
