﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen_tekstbestanden
{

    internal class Oefening4
    {
        string file = "../../../tekst/oefening4.txt";

        public void InputToFile()
        {
            // Open een bestand en vraag telkens opnieuw om input via het toetsenbord.
            // Sla elke regel op in het bestand, zonder de vorige regels te verwijderen.
            // Stop wanneer er een lege regel wordt ingevoerd.
            using (StreamWriter sw = new StreamWriter(file, append: true))
            {
                while(true)
                {
                    Console.Write("Schrijf je bericht: ");
                    string? input = Console.ReadLine();
                    if(input == null || input.Length == 0)
                    {
                        break;
                    }
                    sw.WriteLine(input);
                }
            }
        }


    }
}
