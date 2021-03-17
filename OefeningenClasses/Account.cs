using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningenClasses
{
    class Account
    {
        private string naam;
        private string rekkeningNummer;
        private double bedrag;
        private AccountStatus status;

        public AccountStatus Status
        {
            get { return status; }
            set { status = value; }
        }

        public double Bedrag
        {
            get { return bedrag; }
            set { bedrag = value; }
        }
        public string Rekeningnummer
        {
            get { return rekkeningNummer; }
            set { rekkeningNummer = value; }
        }
        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }
        public Account(string naam)
        {
            this.naam = naam;
            rekkeningNummer = "Tienerrekening";
            bedrag = 50;
            ChangeStatus();

        }
        public Account(string naam, string rekkeningNummer, double bedrag)
        {
            this.naam = naam;
            this.rekkeningNummer = rekkeningNummer;
            this.bedrag = bedrag;
            ChangeStatus();

        }
        public void WithdrawFunds(int getal)
        {
            if (getal > bedrag)
            {
                bedrag = 0;
                Console.WriteLine("niet al het geld kon worden afgehaald ");
            }
            bedrag -= getal;
            ChangeStatus();
        }
        public void PayInFunds(int getal)
        {
            bedrag += getal;
            ChangeStatus();
        }
        public void GetBalance()
        {
            Console.WriteLine(bedrag);
        }
        public string Info()
        {
            return $"{naam}, {rekkeningNummer}: {bedrag} ----- {status}";
        }
        public void ChangeStatus()
        {
            if (bedrag <= -1000)
            {
                Status = AccountStatus.Dood;
            }
            if (bedrag <= 0 && bedrag >= -100)
            {
                Status = AccountStatus.Rood;
            }
            if (bedrag > 0)
            {
                Status = AccountStatus.Groen;
            }

        }
    }
}
