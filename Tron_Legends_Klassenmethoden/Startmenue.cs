using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron_Legends_Klassenmethoden
{
    internal class Startmenue
    {
        public void MenueStart()
        {
            bool exit = true;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\n\n");
                Console.WriteLine("\t\t\t\t\tWillkommen zu Tron Legends\n\n");
                Console.WriteLine("\t\t\t\t\tWillst du spielen? \"Ja\" oder \"Nein\"?");
                Console.WriteLine(" .\r\n  /:\\\r\n  |:|\r\n  |:|\r\n  |:|                              *_   _   _   _   _   _   _   *\r\n  |:|      __                      | `_' `-' `_' `-' `_' `-' `_'|\r\n,_|:|_,   /  )                     |                            |        \r\n  (Oo    / _I_                     |                            |        \r\n   +\\ \\  || __|            ^       |                            |       ^\r\n      \\ \\||___|            |       |                            |       |\r\n        \\ /.:.\\-\\          |  (*)  |_   _   _   _   _   _   _   |  \\^/  |\r\n         |.:. /-----\\      | _<\">_ | `_' `-' `_' `-' `_' `-' `_'| _(#)_ |\r\n         |___|  oOo  |    o+o \\a/ \\0                            0/ \\a/ (=)\r\n         /   ||     0'\\a-a/\\/                            \\/\\a-a/`0\r\n        |_____\\  :  /        /_^_\\ |                            | /_^_\\\r\n         | |  \\ \\:/          || || |                            | || ||\r\n         | |   | |           d|_|b_T____________________________T_d|_|b\r\n         \\ /   | \\___              /                           /\r\n         / |   \\_____\\         /                              /\r\n         `-'               /                                 /");
                string eingabe = Console.ReadLine();

                if (eingabe == "Ja")
                {
                    exit = true;
                }
                else if (eingabe == "Nein")
                {
                    exit = false;
                }
                else
                {
                    Console.WriteLine("Deine Eingabe war ungültig.\nVersuche es erneut.");
                    exit = false;
                }
            } while (exit == false);
        }
    }
}
