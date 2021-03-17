using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningenClasses
{
    enum Klas
    {
        EersteGraad,
        TweedeGraad,
        DerdeGraad
    }
    enum AccountStatus
    {
        Dood,
        Rood,
        Groen
    }

    class Program
    {

        static void
        static void Main(string[] args)
        {

            //Oefening 6
            BankManager bank = new BankManager();

            Account account = new Account("Vincent", "Be73305249......", 42069);
            Account account2 = new Account("Vincent", "Be73306249......", -100);
            Account account3 = new Account("Vincent", "Be73305249......", 42069);

            bank.AddAccount(account);
            bank.AddAccount(account2);
            bank.AddAccount(account3);

            bank.ShowAccount(account.Rekeningnummer);
            bank.ShowAccount(account2.Rekeningnummer);
            bank.SchrijfOverNaar(account2.Rekeningnummer, account.Rekeningnummer, 1000);

            bank.ShowAccount(account.Rekeningnummer);
            bank.ShowAccount(account2.Rekeningnummer);

            //Oefening 5
            Speler speler = new Speler(69420,"vincent",false,true,"Cadet");
            speler.GooiBal();

            //Oefening 4
            Rechthoek rechthoek = new Rechthoek();
            rechthoek.Lengte = 5;
            rechthoek.Breete = 10;
            rechthoek.ToonOppervlakte();

            Driehoek driehoek = new Driehoek();
            driehoek.Basis = 5;
            driehoek.Hoogte = 10;
            Console.WriteLine("hier");
            driehoek.ToonOppervlakte();

            //Oefening 3
            Pizza pizza1 = new Pizza();
            Pizza pizza2 = new Pizza();            
            Console.WriteLine(pizza1.Prijs);

            //Oefening 2
            Student student = new Student();
            student.MijnKlas = Klas.EersteGraad;
            student.Leeftijd = 21;
            student.Naam = "Vincent Callaerts";
            student.PuntenComunicatie = 15;
            student.PuntenProgrammingPrinciples = 15;
            student.PuntenWebTech = 15;
            Console.WriteLine(student.GeefOverzicht()); ;

            //Oefening 1
            Nummers nummer = new Nummers();
            nummer.Getal1 = 5;
            nummer.Getal2 = 2;
            Console.WriteLine(nummer.Som()); ;
            Console.WriteLine(nummer.Verschil());
            Console.WriteLine(nummer.Product());
            Console.WriteLine(nummer.Quotient());

            
            
            Console.ReadLine();
        }
    }
}
