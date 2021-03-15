using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningenClasses
{
    class BankManager
    {

        private List<Account> accounts = new List<Account> { };

        public void AddAccount(Account account)
        {
            int teller = 0;
            for (int i = 0; i < accounts.Count; i++)
            {
                if (account.Rekeningnummer == accounts[i].Rekeningnummer)
                {
                    teller++;
                }
            }
            if (teller == 0)
            {
                accounts.Add(account);
            }
            else
            {
                Console.WriteLine($"Kan account niet aanmaken {account.Rekeningnummer} bestaat al");
            }
            
        }
        public void ShowAccount(string rekkeningNummer)
        {

            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].Rekeningnummer == rekkeningNummer)
                {
                    Console.WriteLine(accounts[i].Info() +" "+ accounts[i].Status);
                }
            }
        
        }
        public void SchrijfOverNaar(string rekkeningNummer1, string rekkeningNummer2, int begrag)
        {

            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].Rekeningnummer == rekkeningNummer1)
                {
                    accounts[i].PayInFunds(begrag);
                }
                else if (accounts[i].Rekeningnummer == rekkeningNummer2)
                {
                    accounts[i].WithdrawFunds(begrag);
                }
            }
        }
    }
}
