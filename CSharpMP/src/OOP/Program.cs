using System;
using OOP.Tier;
using OOP.Einkaufsliste;
using OOP.Benutzer;

class Program
{
       static void Main(string[] args)
    {
        Tier katze = new Tier( "Katze", "Luna", "Miau!");
        Tier hund = new Tier( "Hund", "Bello", "Wuff!");
        Tier schueler = new Tier( "Schüler", "Max", "Blau!");

        katze.MachLaut();
        hund.MachLaut();
        schueler.MachLaut();


        List<Produkt> einkaufList = new List<Produkt>()
        {
            new Produkt("Apfel", 2.20, 4),
            new Produkt("Brot", 1.90, 5),
            new Produkt("Milch", 1.20, 2),
            new Produkt("Eier", 0.20, 12),
            new Produkt("Chips", 99.99, 2)
        };

        foreach (var preis in einkaufList)
            preis.Gesamtpreis();


        List<Benutzer> personen = new List<Benutzer>()
        {
            new Benutzer("Anna", "Schmidt", 25),
            new Benutzer("Jonas", "Weber", 30),
            new Benutzer("Fatima", "Khan", 22),
        };

        foreach (var person in personen)
            person.Vorstellung();
    }

}