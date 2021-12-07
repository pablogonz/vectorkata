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
        
       
        static void Main(string[] args)
        {

        }
    }
}
