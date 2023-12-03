using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen_tekstbestanden
{
    internal class Oefening6
    {
        string file = "../../../tekst/log.txt";

        void AddToLog(string message)
        {
            /*
             * Voeg dit bericht toe aan de logfile. Het bericht moet beginnen met de tijd,
             * bijvoorbeeld
             * 13:20:50 | inhoud bericht
             * Gebruik een uitgebreide foutafhandeling.
             */ 

            

        }

        void ViewLog()
        {
            /*
             * Toon all log messages op het scherm. Gebruik een
             * uitgebreide foutafhandeling.
             */ 

            

        }

        void WriteToLog()
        {
            Console.Write("Schrijf je bericht: ");
            string? line = Console.ReadLine();
            if (line != null)
            {
                AddToLog(line);
            }
        }

        public void Run()
        {
            Menu menu = new Menu();
            menu.AddOption('1', "Schrijf naar het logboek", () => WriteToLog());
            menu.AddOption('2', "Toon het logboek", () => ViewLog());
            menu.Start();
        }
    }
}
