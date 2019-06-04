using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Character
    {   //three choices a player can play (Race)
        static string[] characterDes = 
        {
            "Elves are a magical people of otherworldly grace, living in the world but not entirely part of it. They live in places of ethereal beauty, in the midst of ancient forests or in silvery spires glittering with faerie light, where soft music drifts through the air and gentle fragrances waft on the breeze. Elves love nature and magic, art and artistry, music and poetry, and the good things of the world.",
            "In the reckonings of most worlds, humans are the youngest of the common races, late to arrive on the world scene and short-lived in comparison to dwarves, elves, and dragons. Perhaps it is because of their shorter lives that they strive to achieve as much as they can in the years they are given. Or maybe they feel they have something to prove to the elder races, and that’s why they build their mighty empires on the foundation of conquest and trade. Whatever drives them, humans are the innovators, the achievers, and the pioneers of the worlds.",
            "Whether united under the leadership of a mighty warlock or having fought to a standstill after years of conflict, orc and human tribes sometimes form alliances, joining forces into a larger horde to the terror of civilized lands nearby. When these alliances are sealed by marriages, half-orcs are born. Some half-orcs rise to become proud chiefs of orc tribes, their human blood giving them an edge over their full-blooded orc rivals. Some venture into the world to prove their worth among humans and other more civilized races. Many of these become adventurers, achieving greatness for their mighty deeds and notoriety for their barbaric customs and savage fury.",
        };
        public static string[] characterClass =
        {
            "Barbarian", "Bard","Cleric",
            "Druid", 
            "sorcerer",
        };
        public static string[] ClassDes =
       {    "Barbarians:\nBarbarians come alive in the chaos of combat. They can enter a berserk state where rage takes over, giving them superhuman strength and resilience. A barbarian can draw on this reservoir of fury only a few times without resting, but those few rages are usually sufficient to defeat whatever threats arise.",
            "Bard:\nThe greatest strength of bards is their sheer versatility. Many bards prefer to stick to the sidelines in combat, using their magic to inspire their allies and hinder their foes from a distance. But bards are capable of defending themselves in melee if necessary, using their magic to bolster their swords and armor. Their spells lean toward charms and illusions rather than blatantly destructive spells. They have a wide-ranging knowledge of many subjects and a natural aptitude that lets them do almost anything well. Bards become masters of the talents they set their minds to perfecting, from musical performance to esoteric knowledge.",
            "Cleric:\nClerics combine the helpful magic of healing and inspiring their allies with spells that harm and hinder foes. They can provoke awe and dread, lay curses of plague or poison, and even call down flames from heaven to consume their enemies. For those evildoers who will benefit most from a mace to the head, clerics depend on their combat training to let them wade into melee with the power of the gods on their side.",
            "Druid:\nDruid spells are oriented toward nature and animals—the power of tooth and claw, of sun and moon, of fire and storm. Druids also gain the ability to take on animal forms, and some druids make a particular study of this practice, even to the point where they prefer animal form to their natural form.",
            "Sorcerer:\nMagic is a part of every sorcerer, suffusing body, mind, and spirit with a latent power that waits to be tapped. Some sorcerers wield magic that springs from an ancient bloodline infused with the magic of dragons. Others carry a raw, uncontrolled magic within them, a chaotic storm that manifests in unexpected ways.",  
        };

        String one = "[1]";
        String two = "[2]";
        String n = "\n";
        //Dynamic output from console
        static string Dialogue;
        //dynamic inut from player
        static string Choice;
        //character name
        static string characterName = "";
        public static string plName;
        public static string plRace;
        public static string plClass;
        //constructor
        public Character()
        {
            
            plName = PlayerName();
            plRace = ChooseRace();
            string plClass = ChooseClass();
            Item Gold = new Item();
            Gold.name = "Gold";
            Gold.description = "200";
            Item.Inventory.Add(Gold.name);
        }
        //ask player for a name, and save it
        public static string PlayerName()
        {
            Dialogue = "\n Brave Patron of the Computer arts! To What do ye call yeself?";
            Animationsand_effects.TypeWriter(Dialogue, "blue");
            characterName = Console.ReadLine();
            Dialogue = " I bid ye welcome ";
            Animationsand_effects.TypeWriter(Dialogue, "blue");
            Animationsand_effects.Dialog(characterName, "magenta");
            Dialogue = " I wish ye great tidings on your journey ahead...";
            Animationsand_effects.TypeWriter(Dialogue, "blue");
            Console.ReadKey();
            return characterName;
        }
        //chooe race dialogue
        public static string ChooseRace()
        {
            Console.Clear();
            String Input = "";
            String Human = " Human";
            String Elf = " Elf";
            String Orc = " Half Orc";
            Dialogue = "\n Choose your Race: \n [1]" + Human + "\n [2]" + Elf + "\n [3]" + Orc + "\n";
            Animationsand_effects.TypeWriter(Dialogue, "blue");
            Input = Console.ReadLine();
            if (Input == "1") { Character.Human(); }
            if (Input == "2") { Character.Elf(); }
            if (Input == "3") { Character.Orc(); }
            return Choice;

        }
        public static string ChooseClass()
        {
            Console.Clear();
            Dialogue = " can choose between two Classes:\n";
            Console.Write(plName);
            Animationsand_effects.TypeWriter(Dialogue, "magenta");
            if (plRace == "Orc")
            {
                Console.WriteLine("[1]" + characterClass[0] );
                Console.WriteLine(ClassDes[0]);
                Console.WriteLine("[2]" + characterClass[2]);
                Console.WriteLine(ClassDes[2]);
            }
            if (plRace == "Elf")
            {
                Console.WriteLine("[1]" + characterClass[3]);
                Console.WriteLine(ClassDes[3]);
                Console.WriteLine("\n" + "[2]" + characterClass[1]);
                Console.WriteLine(ClassDes[1]);
            }
            if (plRace == "Human")
            {
                Console.WriteLine("[1]"+characterClass[0] );
                Console.WriteLine(ClassDes[0]);
                Console.WriteLine("[2]" + characterClass[4]);
                Console.WriteLine(ClassDes[4]);
            }
            Choice = ClassChoice();
            
            return Choice;
        }
        public static string ClassChoice() {
            Dialogue = " \n So Which shall Ye Be? \n type in you choice.";
            Animationsand_effects.TypeWriter(Dialogue, "magenta");
            Choice = Console.ReadLine();
            if (Choice == characterClass[0]) {  Choice  = characterClass[0]; }
            if (Choice == characterClass[1]) {  Choice = characterClass[1]; }
            if (Choice == characterClass[2]) { Choice = characterClass[2]; }
            if (Choice == characterClass[3]) { Choice = characterClass[3]; }
            if (Choice == characterClass[4]) {  Choice = characterClass[4]; }
            Dialogue = " You have Chosen: ";
            Animationsand_effects.TypeWriter(Dialogue, "magenta");
            Console.WriteLine(Choice);
            return Choice;
        }
        
        public static string Elf()
        {
            Console.WriteLine(@"ELF      
                    .-----.
                     \ ' /   _/    )/
                    - ( ) -('---''--)
                     / . \((()\^_^/)()
                      \\_\ (()_)-((()()
                       '- \ )/\._./(()
                         '/\/( X   ) \
                         (___)|___/ ) \
                              |.#_|(___)
                             /\    \ ( (_
                             \/\/\/\) \\
                             | / \ |
                             |(   \|
                            _|_)__|_\_
                            )...()...(
                             | (   \ |     
                          .-'__,)  (  \
                      mrf           '\_-,");
            Dialogue = characterDes[0];
            Console.Write(Dialogue);
            Choice = DoYouChoose();
            if (Choice == "1")
            {
                Choice = "Elf";
            }
            else {
                ChooseRace();
            }
            return Choice;
        }
        public static string Human()
        {
            Console.WriteLine(@"HUMAN      
              {}
             .--.
            /.--.\
            |====|
            |`::`|
        .-;`\..../`;-.
       /  |...::...|  \
      |   /'''::'''\   |
      ;--'\   ::   /\--;
      <__>,>._::_.<,<__>
      |  |/   ^^   \|  |
      \::/|        |\::/
      |||\|        |/|||
      ''' |___/\___| '''
           \_ || _/
           <_ >< _>
           |  ||  |
           |  ||  |
          _\.:||:./_
    jgs  /____/\____\");
            Dialogue = characterDes[1];
            Console.Write(Dialogue);
            Choice = DoYouChoose();
            if (Choice == "1")
            {
                Choice = "Human";
            }
            else
            {
                ChooseRace();
            }
            return Choice;
        }
        public static string Orc()
        {
            Console.WriteLine(@"HALF ORC 
                        _,.---''```````'-.
                    ,-'`                  `-._
                 ,-`                   __,-``,\
                /             _       /,'  ,|/ \
              ,'         ,''-<_`'.    |  ,' |   \
             /          / _    `  `.  | / \ |\  |
             |         (  |`'-,---, `'  \_|/ |  |
             |         |`  \  \|  /  __,    _ \ |
             |         |    `._\,'  '    ,-`_\ \|
             |         |        ,----      /|   )
             \         \       / --.      {/   /|
              \         | |       `.\         / |
               \        / `-.                 | /
                `.     |     `-        _,--V`)\/        _,-
                  `,   |           /``V_,.--`  \.  _,-'`
                   /`--'`._        `-'`         )`'
                  /        `-.            _,.-'`
                              `-.____,.-'`
");
            Dialogue = characterDes[2];
            Console.Write(Dialogue);
           Choice = DoYouChoose();
            if (Choice == "1")
            {
                Choice = "Orc";
            }
            else
            {
                ChooseRace();
            }
            return Choice;
        }
        public static string DoYouChoose()
        {
            Dialogue = " Do you sih to choose this? [1] Yes [2] No";
            Animationsand_effects.TypeWriter(Dialogue, "magenta");
            Choice = Console.ReadLine();
            
            return Choice;
        }
    }

}
