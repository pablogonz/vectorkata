using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vectorkata
{
    public class vectorops
    {
        public double u { get; set; }
        public double v { get; set; }

        public vectorops(double x, double y)
        {
            this.u = x;
            this.v = y;
        }
            public double Magnitudeop()
            {
                double pit = Math.Pow(this.u, 2) + Math.Pow(this.v, 2);
                double total = Math.Sqrt(pit);


                return pit;

            }

        public static double proudctdot(vectorops vectorx, vectorops vectory)
        {
            double i = vectorx.u * vectory.v;
            double j = vectory.v * vectorx.u;

            return (i * j);


        }
        public static double betweenangle(vectorops vectorx, vectorops vectory)
        {
           double  process = Math.Atan2(vectory.v, vectorx.u) - Math.Atan2(vectorx.u, vectory.v);
            return Math.Acos(process) * (180) /3.1416;
        }
        static void Main(string[] args)
        {

        }
    }
}
