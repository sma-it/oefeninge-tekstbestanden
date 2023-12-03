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

            try
            {
                using(StreamWriter sw = new StreamWriter(file, append: true))
                {
                    sw.WriteLine(DateTime.Now.ToString("HH:mm:ss") + " | " + message);
                }
            } catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            } catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            } catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        void ViewLog()
        {
            /*
             * Toon all log messages op het scherm. Gebruik een
             * uitgebreide foutafhandeling.
             */ 

            try
            {
                using(StreamReader sr = new StreamReader(file))
                {
                    string? line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

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
