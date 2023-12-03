using System;

namespace Oefeningen_tekstbestanden
{
    internal class Oefening2
    {
        string file1 = "../../../tekst/oefening1.txt";
        string file2 = "../../../tekst/oefening2.txt";

        List<string> file1Content = new List<string>();
        List<string> file2Content = new List<string>();

        public void ReadAndCompare()
        {
            // Lees beide bestanden in en plaats de inhoud in de
            // lists. Vergelijk de lists en toon de regel van het tweede bestand
            // op het scherm als die niet voorkomt in het eerste bestand.

            using (StreamReader reader = new StreamReader(file1))
            {
                string? line;

                // Lees het bestand regel voor regel
                while ((line = reader.ReadLine()) != null)
                {
                    file1Content.Add(line);
                }
            }

            using (StreamReader reader = new StreamReader(file2))
            {
                string? line;

                // Lees het bestand regel voor regel
                while ((line = reader.ReadLine()) != null)
                {
                    file2Content.Add(line);
                }
            }

            foreach(string line in file2Content)
            {
                if (!file1Content.Contains(line))
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
