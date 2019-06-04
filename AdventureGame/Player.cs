using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Player

    {
        public Player()
        {
            Character charac = new Character();
        }
        
        public void Confirm(String Choice)
        {
            String Dialogue = " You've Chosen: ";
            Animationsand_effects.TypeWriter(Dialogue, "magenta");
            Console.WriteLine(Choice);
        }
    }
}
