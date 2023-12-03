using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen_tekstbestanden
{
    internal class Oefening5
    {
        string path = "../../../tekst/";

        public void DoesExist()
        {
            /*
             * Vraag om een bestandsnaam tot de invoer leeg is.
             * Als het bestand bestaat, dan toon je op het scherm de melding
             * "this file exists". Als het bestand niet bestaat, dan toon je 
             * de foutmelding van de Exception.
             */
            
            while (true)
            {
                Console.Write("Bestandsnaam: ");
                string? input = Console.ReadLine();
                if (input == null || input.Length == 0)
                {
                    break;
                }
                try
                {
                    using (StreamReader reader = new StreamReader(path + input))
                    {
                        Console.WriteLine("This file exists");
                    }
                } catch (FileNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
