using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningenClasses
{
    class Speler
    {
        private int rugnummer;
        private string naam;
        private bool isDoelman;
        private bool isReserve;
        private string reeks;

        public string Reeks
        {
            get { return reeks; }
            set { reeks = value; }
        }
        public bool IsDoelman
        {
            get { return isDoelman; }
            set { isDoelman = value; }
        }
        public bool IsReserve
        {
            get { return isReserve; }
            set { isReserve = value; }
        }
        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }
        public int Rugnummer
        {
            get { return rugnummer; }
            set { rugnummer = value; }
        }
        

        public Speler(int rugnummer,string naam,bool isDoelman, bool isReserve, string reeks) 
        {
            this.rugnummer = rugnummer;
            this.naam = naam;
            this.isDoelman = isDoelman;
            this.isReserve = isReserve;
            this.reeks = reeks;
        }
        public void GooiBal() 
        {
            Console.WriteLine($"{naam} #{rugnummer}, gooit de bal");
        }

        
    }
}
