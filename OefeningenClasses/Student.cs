using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningenClasses
{


    class Student
    {

        private int leeftijd;
        private string naam;
        private int puntenComunicatie;
        private int puntenProgrammingPrinciples;
        private int puntenWebTech;
        private Klas mijnKlas;

        public Klas MijnKlas
        {
            get { return mijnKlas; }
            set { mijnKlas = value; }
        }
        public int PuntenWebTech
        {
            get { return puntenWebTech; }
            set { puntenWebTech = value; }
        }
        public int PuntenProgrammingPrinciples
        {
            get { return puntenProgrammingPrinciples; }
            set { puntenProgrammingPrinciples = value; }
        }
        public int PuntenComunicatie
        {
            get { return puntenComunicatie; }
            set { puntenComunicatie = value; }
        }
        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }
        public int Leeftijd
        {
            get { return leeftijd; }
            set { leeftijd = value; }
        }
        private double Gemiddelde()
        {
            double temp = (puntenComunicatie + puntenProgrammingPrinciples + puntenWebTech) / 3;
            return Math.Round(temp, 1);

        }
        public string GeefOverzicht()
        {
            string overzicht = string.Empty;
            overzicht = $"{naam}, {leeftijd} jaar\nKlas: {mijnKlas}\n\n";
            overzicht += $"Cijferrapport:\n***************\nComunicatie:\t\t{puntenComunicatie}\n";
            overzicht += $"Programming Principles: {puntenProgrammingPrinciples}\n";
            overzicht += $"Web Tech:\t\t{puntenWebTech}\n";
            overzicht += $"Gemiddelde:\t\t{Gemiddelde()}";
            return overzicht;
        }
    }
}
