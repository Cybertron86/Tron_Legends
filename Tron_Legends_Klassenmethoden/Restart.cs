using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron_Legends_Klassenmethoden
{
    internal class Restart
    {
        public static bool Restart1()
        {

            string aktion = "";
            Console.Clear();
            Console.WriteLine("\n\n\n\t\t\t\t\t\t\tEnde!");
            
            do
            {
                Console.WriteLine("\n\n\nMöchtest du nochmal spielen? \"Ja\" oder \"Nein\"");
                aktion = Console.ReadLine();
                if (aktion == "Ja")
                {
                    Console.Clear();
                    Console.WriteLine("Das Spiel startet in 10 Sekunden neu.");
                    Thread.Sleep(10000);
                    return true;
                }
                else if (aktion == "Nein")
                {
                    Console.Clear();
                    Console.WriteLine("Du möchtest nicht nochmal spielen.\nTschüss und bis bald.");
                    Thread.Sleep(5000);
                    return false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Du musst entweder \"Ja\" oder \"Nein\" eingeben.");
                    Thread.Sleep(5000);
                }
            } while (true);
        }
    }
}
