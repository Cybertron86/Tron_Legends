using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron_Legends_Klassenmethoden
{
    internal class Charackter
    {
        string geschlecht;
        int alter;
        int groesse;
        int gewicht;

        public Charackter()
        { }

        public Charackter(string geschlecht, int alter, int groesse, int gewicht)
        {
            Geschlecht = geschlecht;
            Alter = alter;
            Groesse = groesse;
            Gewicht = gewicht;
        }

        public string Geschlecht { get => geschlecht; set => geschlecht = value; }
        public int Alter { get => alter; set => alter = value; }
        public int Groesse { get => groesse; set => groesse = value; }
        public int Gewicht { get => gewicht; set => gewicht = value; }



        public void Charakter()
        {
            bool exit2 = true;
            Console.Clear();

            string eingabeGeschlecht;
            int eingabeAlter;
            int eingabeGroesse;
            int eingabeGewicht;
            
            do
            {
                Console.WriteLine("Bitte wähle nun dein Geschlecht aus \"Mann\" oder \"Frau\".");
                Geschlecht = Console.ReadLine();
                if (Geschlecht == "Mann" || Geschlecht == "Frau")
                {
                    Console.WriteLine($"Deine Auswahl {Geschlecht} ist gültig");
                    Thread.Sleep(3000);
                    exit2 = true;
                }
                else
                {
                    Console.WriteLine("Deine Eingabe war ungültig.\nVersuche es erneut");
                    exit2 = false;
                }
            } while (exit2 == false);

            Console.Clear();
            exit2 = true;
            do
            {

                Console.WriteLine("Bitte gib nun dein Alter in vollen Jahren zwischen 18 und 99 ein.");
                eingabeAlter = Convert.ToInt32(Console.ReadLine());
                if (eingabeAlter >= 18 && eingabeAlter <= 99)
                {
                    Console.WriteLine($"Dein gewähltes Alter ist {eingabeAlter} Jahre");
                    Thread.Sleep(3000);
                    exit2 = true;
                }
                else
                {
                    Console.WriteLine("Dein gewähltes Alter war ungültig.\nVersuche es noch einmal.");
                    exit2 = false;
                }
            } while (exit2 == false);

            Console.Clear();
            exit2 = true;

            do
            {
                Console.WriteLine("Bitte gib nun deine Größe in ganzen Zentimetern ein, von 140 cm bis 220 cm.");
                eingabeGroesse = Convert.ToInt32(Console.ReadLine());
                if (eingabeGroesse >= 140 && eingabeGroesse <= 220)
                {
                    Console.WriteLine($"Deine gewählte Größe beträgt {eingabeGroesse} cm");
                    Thread.Sleep(3000);
                    exit2 = true;
                }
                else
                {
                    Console.WriteLine("Deine gewählte Größe war ungültig.\nVersuche es noch einmal.");
                    exit2 = false;
                }
            } while (exit2 == false);

            Console.Clear();
            exit2 = true;

            do
            {
                Console.WriteLine("Bitte gib nun dein Gewicht in ganzen Kilogramm ein, von 50 Kg bis 200 Kg.");
                eingabeGewicht = Convert.ToInt32(Console.ReadLine());
                if (eingabeGewicht >= 50 && eingabeGewicht <= 200)
                {
                    Console.WriteLine($"Dein gewähltes Gewicht beträgt {eingabeGewicht} kg");
                    Thread.Sleep(3000);
                    exit2 = true;
                }
                else
                {
                    Console.WriteLine("Dein gewähltes Gewicht war ungültig.\nVersuche es noch einmal.");
                    exit2 = false;
                }
            } while (exit2 == false);


            

            
            Console.Clear();
            Console.WriteLine($"Nephalem, Sie haben gewählt:\n\n\tGeschlecht: {Geschlecht}\n\tAlter: {eingabeAlter}\n\tGröße: {eingabeGroesse} cm\n\tGewicht: {eingabeGewicht} kg ");
            Console.WriteLine("\n\nDrücken Sie eine beliebige Taste um fortzufahren.");
            Console.ReadKey();
        }
    }


    
}
