using System;

namespace Oefeningen_tekstbestanden
{
    internal class Oefening1
    {
        // Het pad naar het bestand dat we willen lezen 
        string filePath = "../../../tekst/oefening1.txt";

        public void ReadAndPrint()
        {
            // Open dit bestand en toon elke regel op het scherm
            using (StreamReader reader = new StreamReader(filePath))
            {
                string? line;

                // Lees het bestand regel voor regel
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
