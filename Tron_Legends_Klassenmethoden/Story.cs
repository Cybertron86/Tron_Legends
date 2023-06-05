using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron_Legends_Klassenmethoden
{
    internal class Story
    {
        public void Storyline(Charackter charakter)
        {
            Console.Clear();
            Console.WriteLine("\n\t\t\t\tWir schreiben das Jahr 1505 und es herrscht Krieg über Mittelerde.");
            Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("\nNephalem, Sie sind unsere einzige Hoffnung diese Schriftrolle mit der Mitteilung über die anstehende\nInvasion des Blutclans, an den König Arthas zu übergeben.");
            Thread.Sleep(12000);
            Console.Clear();
            Console.WriteLine("\nFinden Sie einen Weg zu König Arthas, Nepahlem und übergeben Sie ihm die Schriftrolle.\nOdin möge Ihnen beistehen.\nNun geh Nephalem!");
            Thread.Sleep(12000);
            Console.Clear();
            Console.WriteLine("Mitteilung: Schriftrolle erhalten!\n\nMitteilung: Schwert erhalten!");
            Thread.Sleep(7000);
            Console.Clear();
           


            string wegGehen = "nichtGehen";
            string eingabeWeg = "";
            bool check;
            bool whd = true;
            string aktion = "";


            do
            {


                if (wegGehen == "nichtGehen")
                {
                    do
                    {

                        Console.Clear();
                        check = true;
                        Console.WriteLine("Nephalem, du stehst nun vor den Toren deiner Festung.\n\nEs gibt 3 Wege die du wählen kannst.\n\n\tGib Links ein um nach Links zu gehen.\n\n\tGib Vorwaerts ein, um Vorwaerts zu gehen.\n\n\tGib Rechts ein, um nach Rechts zu gehen");
                        eingabeWeg = Console.ReadLine();
                        if (eingabeWeg == "Links")
                        {
                            Console.WriteLine("Du gehst nach Links und bist nun an einem schmalen Weg, der rechts und links\nmit hohen, unüberwindbaren Felsen geschmückt ist.");
                            check = true;
                            Thread.Sleep(8000);

                        }
                        else if (eingabeWeg == "Vorwaerts")
                        {
                            Console.WriteLine("Du gehst Vorwaerts und findest dich vor einem riesigen dichten und nicht durchquerbaren Wald wieder");
                            check = true;
                            Thread.Sleep(8000);
                        }
                        else if (eingabeWeg == "Rechts")
                        {
                            Console.WriteLine("Du gehst nach Rechts und stehst nun vor einem Moor, dass unüberwinbar erscheint.");
                            check = true;
                            Thread.Sleep(6000);
                        }
                        else
                        {
                            Console.WriteLine("Deine Eingabe war ungültig. Bitte gib entweder \"Links\",\"Vorwaerts\" oder \"Rechts\" ein.");
                            check = false;
                            Thread.Sleep(5000);
                        }
                    } while (check == false);
                }


                if (wegGehen == "nichtGehen")
                {
                    do
                    {
                        check = true;
                        Console.Clear();
                        if (eingabeWeg == "Rechts")
                        {
                            Console.WriteLine("Du stehst nun vor einem scheinbar unüberwindbarem Moor.\n\nDu hast 3 Optionen:\n\tMoor durchqueren\n\tumschauen\n\tzurück");
                            aktion = Console.ReadLine();
                        }
                        if (aktion == "Moor durchqueren" && eingabeWeg == "Rechts")
                        {
                            Console.WriteLine("Du kannst das Moor nicht durchqueren.");
                            check = false;
                            Thread.Sleep(5000);
                        }
                        else if (aktion == "umschauen" && eingabeWeg == "Rechts")
                        {
                            Console.WriteLine("Hier gibt es nichts außergewöhliches zu sehen.");
                            check = false;
                            Thread.Sleep(5000);
                        }
                        else if (aktion == "zurück" && eingabeWeg == "Rechts")
                        {
                            Console.WriteLine("Du gehst den Weg wieder zurück.");
                            check = true;
                            Thread.Sleep(5000);
                        }
                        else if (aktion != "Moor durchqueren" && eingabeWeg == "Rechts" || aktion != "umschauen" && eingabeWeg == "Rechts" || aktion != "zurück" && eingabeWeg == "Rechts")
                        {
                            Console.WriteLine("Bitte gib als Option entweder \"Moor durchqueren\",\"umschauen\" oder \"zurück\" ein.");
                            check = false;
                            Thread.Sleep(6000);
                        }


                    } while (check == false);
                }




                if (wegGehen == "nichtGehen")
                {
                    do
                    {
                        check = true;
                        Console.Clear();
                        if (eingabeWeg == "Vorwaerts")
                        {
                            Console.WriteLine("Du befindest dich nun vor einem dichten und scheinbar undurchquerbaren Wald.\n\nDu hast 3 Optionen\n\tWald durchqueren\n\tumschauen\n\tzurück");
                            aktion = Console.ReadLine();
                        }
                        if (aktion == "Wald durchqueren" && eingabeWeg == "Vorwaerts")
                        {
                            Console.WriteLine("Der Wald ist zu Dicht. Du kannst ihn nicht durchqueren");
                            check = false;
                            Thread.Sleep(5000);
                        }
                        else if (aktion == "umschauen" && eingabeWeg == "Vorwaerts")
                        {
                            Console.WriteLine("Hier gibt es nichts besonderes zu sehen.");
                            check = false;
                            Thread.Sleep(5000);
                        }

                        else if (aktion == "zurück" && eingabeWeg == "Vorwaerts")
                        {
                            Console.WriteLine("Du gehst den Weg zurück");
                            check = true;
                            Thread.Sleep(5000);
                        }
                        else if (aktion != "Wald durchqueren" && eingabeWeg == "Vorwaerts" || aktion != "zurück" && eingabeWeg == "Vorwaerts" || aktion != "umschauen" && eingabeWeg == "Vorwaerts")
                        {
                            Console.WriteLine("Bitte gebe als Option entweder \"Wald durchqueren\", \"umschauen\" oder \"zurück\" ein.");
                            check = false;
                            Thread.Sleep(6000);
                        }
                    } while (check == false);
                }





                if (wegGehen == "nichtGehen")
                {
                    do
                    {
                        check = true;
                        Console.Clear();
                        if (eingabeWeg == "Links")
                        {
                            Console.WriteLine("Du stehst nun auf einem schmalen Weg, der links und rechts von dir von hohen Felsen umgeben ist.\n\nDu hast 3 Optionen zu wählen: \n\n\t\"Weg gehen\"\n\t\"umschauen\"\n\t\"zurück\"");
                            aktion = Console.ReadLine();
                        }
                        if (aktion == "Weg gehen" && eingabeWeg == "Links")
                        {
                            Console.WriteLine("Du gehst den Weg entlang");
                            check = true;
                            wegGehen = "okay";
                            Thread.Sleep(5000);
                            whd = false;
                        }
                        else if (aktion == "umschauen" && eingabeWeg == "Links")
                        {
                            Console.WriteLine("Hier gibt es nichts auffälliges zu sehen.");
                            check = false;
                            Thread.Sleep(5000);
                        }
                        else if (aktion == "zurück" && eingabeWeg == "Links")
                        {
                            Console.WriteLine("Du gehst zurück");
                            check = true;
                            Thread.Sleep(5000);
                        }
                        else if (aktion != "Weg gehen" && eingabeWeg == "Links" || aktion != "umschauen" && eingabeWeg == "Links" || aktion != "zurück" && eingabeWeg == "Links")
                        {
                            Console.WriteLine("Bitte gib als Option entweder: \"Weg gehen\", \"umschauen\" oder \"zurück\" ein.");
                            check = false;
                            Thread.Sleep(5000);
                        }
                    } while (check == false);
                }
            } while (whd == true);






            string angreifen = "Nein";



            if (wegGehen == "okay")
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Du stehst nun vor einem Banditen. Er blockiert dir den Weg. Was willst du tun?\nDu hast 3 Optionen:\n\n\t\"Angreifen\"\n\t\"Bestechen\"\n\t\"zurück fliehen\"");
                    aktion = Console.ReadLine();


                    if (aktion == "Angreifen")
                    {
                        Console.WriteLine("Du schlägst mit deinem Schwert zu und landest einen kritischen Treffer.\nDer Bandit geht schwer verwundet zu Boden.");
                        check = true;
                        Thread.Sleep(10000);
                        angreifen = "Ja";
                    }
                    else if (aktion == "Bestechen")
                    {
                        Console.WriteLine("Der Bandit lacht dich aus und sagt:\"Mich kann man nicht bestechen\"");
                        check = false;
                        Thread.Sleep(7000);
                    }
                    else if (aktion == "zurück fliehen")
                    {
                        Console.WriteLine("Du drehst dich um und willst fliehen, doch bemerkst, dass die Felswände eingestürzt sind und du nicht mehr zurück kannst.");
                        check = false;
                        Thread.Sleep(7000);

                    }
                    else
                    {
                        Console.WriteLine("Deine Eingabe war ungültig.\nGib entweder \"Angreifen\", \"Bestechen\" oder \"zurück fliehen\" ein.");
                        check = false;
                        Thread.Sleep(6000);
                    }
                } while (check == false);
            }






            if (angreifen == "Ja")
            {
                do
                {
                    Console.Clear();
                    check = true;
                    Console.WriteLine("Der Weg den der Bandit zuvor blockierte ist nun frei.\nDu gehst an dem auf dem Boden liegenden schwer verletzten Banditen vorbei.\nAls du den Weg eine Weile weitergefolgt bist, siehst du nach einer Biegung das Schloss von König Arthas.\nDu gehst darauf zu und wirst vor den Toren von zwei Wachen aufgehalten, wobei die eine Wache frägt, wer du bist und was dein Anliegen sei.\n\nDu hast 2 Antwortmöglichkeiten:\n\n\t\"Nichts angehen\"\noder\n\n\t\"Nephalem\"");
                    aktion = Console.ReadLine();

                    if (aktion == "Nichts angehen")
                    {
                        Console.Clear();
                        Console.WriteLine("Du:\"Das geht dich nichts an, wer ich bin oder was ich möchte. Lasse mich durch, ich muss zu König Arthas!\"");
                        Console.WriteLine("Wache:\"Ohne wichtigen Grund kann ich dich nicht vorbei lassen. Nun gehe wieder fremder!\"");
                        check = false;
                        Console.WriteLine("\n\nTaste drücken um fortzufahren.");
                        Console.ReadKey();
                    }
                    else if (aktion == "Nephalem")
                    {
                        Console.Clear();
                        Console.WriteLine("Du:\"Mein Name ist Nepahelm und ich habe ein Schriftrolle, die ich König Arthas übergeben muss.\nDies ist von höchster Dringlichkeit.\"");
                        Console.WriteLine("\nWache:\"Der Nephalem? Der größte Krieger unseres Königreichs?\nIch habe viel von Ihnen gehört. Es ist mir eine Ehre Sie Auge in Auge zu sehen.\nNun Nephalem, gehen Sie vorbei und erfüllen Sie Ihre Mission!\"");
                        check = true;
                        Console.WriteLine("\n\nTaste drücken um fortzufahren.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Du musst entweder \"Nichts angehen\" oder \"Nephalem\" eingeben.");
                        check = false;
                    }
                } while (check == false);
            }

            Console.Clear();
            Console.WriteLine("Du schreitest durch die Tore des Schlosses und begibst dich auf den Weg zu König Arthas");
            Thread.Sleep(7000);
            Console.Clear();
            Console.WriteLine("Nach dem Authentifizieren stehst du nun König Arthas gegenüber.");
            Thread.Sleep(7000);


            do
            {
                check = true;
                Console.Clear();
                Console.WriteLine("Arthas:\"Nephalem, größter Krieger unseres Königreichs. Was führt dich zu mir. Nenne mir dein Anliegen\"\n\nGib nun \"Schriftrolle\" ein, um König Arthas die Schriftrolle zu übergeben.");
                aktion = Console.ReadLine();

                if (aktion == "Schriftrolle")
                {
                    Console.Clear();
                    Console.WriteLine("Du übergibst König Arthas die Schriftrolle.\nEr öffnet Sie, liest Sie und schaut dich dann an.");
                    Thread.Sleep(6000);
                    Console.Clear();
                    Console.WriteLine("Arthas:\"Nephalem, ich stehe tief in eurer Schuld.\nDank Ihres unermüdlichen und furchtlosen Einsatz, sind wir nun informiert.\nWir werden sofort Gegenmaßnahmen ergreifen, um die drohende Invasion abwehren zu können.\nDu kannst dich nun wieder auf die Heimreise begeben Nephalem.\"");
                    Console.WriteLine("\n\nDrücke eine Taste um fortzufahren.");
                    Console.ReadKey();
                    check = true;

                }
                else
                {
                    Console.WriteLine("Deine Eingabe war ungültig. Du musst \"Schriftrolle\" eingeben.");
                    check = false;
                }
            } while (check == false);
        }
    }
}
