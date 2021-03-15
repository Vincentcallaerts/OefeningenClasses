using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningenClasses
{
    class Driehoek
    {
        private int basis;
        private int hoogte;

        public int Hoogte
        {
            get { return hoogte; }
            set { hoogte = value; }
        }

        public int Basis
        {
            get { return basis; }
            set { basis = value; }
        }
        public void ToonOppervlakte()
        {

            Console.WriteLine(Convert.ToDouble(basis * hoogte)/2);

        }

    }
}
