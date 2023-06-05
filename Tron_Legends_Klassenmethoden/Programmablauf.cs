using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron_Legends_Klassenmethoden
{
    internal class Programmablauf
    {
        public void AblaufProgramm()
        {

            Startmenue startmenue = new Startmenue();
            startmenue.MenueStart();

            Charackter charakter = new Charackter();

            charakter.Charakter();

            Story story = new Story();
            story.Storyline(charakter);
        }
    }
}
