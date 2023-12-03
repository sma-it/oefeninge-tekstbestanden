using System;

namespace Oefeningen_tekstbestanden
{
    internal class Oefening3
    {
        List<string> content = new List<string>();
        string file = "../../../tekst/oefening3.txt";

        public void WriteList()
        {
            /* 
             * Schrijf de inhoud van de list naar een bestand.
             * Open daarna dit bestand via de verkenner en controleer
             * of de inhoud klopt.
             */

            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach(string item in content)
                {
                    writer.WriteLine(item);
                }
            }

        }

        public void FillList()
        {
            content.Clear();
            content.Add("In a digital world, neatly arrayed,");
            content.Add("JSON weaves data, meticulously laid.");
            content.Add("Keys and values in harmony flow,");
            content.Add("A code ballet, making the virtual glow.");
        }
    }
}
