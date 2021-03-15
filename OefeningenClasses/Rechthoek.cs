using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningenClasses
{
    class Rechthoek
    {
        private int lengte;
        private int breete;

        public int Breete
        {
            get { return breete; }
            set { breete = value; }
        }

        public int Lengte
        {
            get { return lengte; }
            set { lengte = value; }
        }
        public void ToonOppervlakte()
        {

            Console.WriteLine(lengte*breete);
        
        }

    }
}
