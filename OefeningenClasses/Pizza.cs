using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningenClasses
{
    class Pizza
    {

        private string toppings;
        private int diameter;
        private double prijs;

        public double Prijs
        {
            get { return prijs; }
            set {
                if (value > 0)
                {
                    prijs = value;
                }
            }
        }

        public int Diameter
        {
            get { return diameter; }
            set
            {
                if (value > 0)
                {
                    diameter = value;
                }
            }
        }

        public string Toppings
        {
            get { return toppings; }
            set { toppings = value; }
        }


    }
}
