using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningenClasses
{
    class Nummers
    {

        private int getal1;
        private int getal2;

        public int Getal1
        {
            get { return getal1; }
            set { getal1 = value; }
        }
        public int Getal2
        {
            get { return getal2; }
            set { getal2 = value; }
        }
        public int Som() 
        {

            return getal1 + getal2;

        }
        public int Verschil()
        {

            return getal1 - getal2;

        }
        public int Product()
        {

            return getal1 * getal2;

        }
        public double Quotient()
        {
            if (getal2 != 0) {
                return getal1 / getal2;
            }
            else
            {
                Console.WriteLine("Error");
                return 0;
            }

            
        }

    }
}
