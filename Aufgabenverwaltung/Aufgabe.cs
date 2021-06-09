using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabenverwaltung
{
    public class Aufgabe
    {
        public int Id { get; set; } = -1;
        public string Bezeichnung { get; set; }
        public DateTime Abgabedatum { get; set; } 
        public string Mitarbeiter { get; set; }
        public int Erledigungsgrad { get; set; }

        public Aufgabe(int id, string bezeichnung, DateTime abgabedatum, string mitarbeiter, int erledigungsgrad) // für sql
        {
            Id = id;
            Bezeichnung = bezeichnung;
            Abgabedatum = abgabedatum;           
            Mitarbeiter = mitarbeiter;
            Erledigungsgrad = erledigungsgrad;
            
        }
        public Aufgabe(string bezeichnung, DateTime abgabedatum, string mitarbeiter, int erledigungsgrad) // für .csv
        {
            Bezeichnung = bezeichnung;
            Abgabedatum = abgabedatum;           
            Mitarbeiter = mitarbeiter;
            Erledigungsgrad = erledigungsgrad;
            
        }

        public override string ToString()
        {
            //TODO - Darstellung verschönern
            
            return $"{Bezeichnung} ({Erledigungsgrad}%)  bis: {Abgabedatum:dd/MM/yyyy}  von: {Mitarbeiter}";
        }
    }
}
