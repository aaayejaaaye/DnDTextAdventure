using System;

namespace AdventureGame
{
    class Program
    {
        static void Main()
        {
  
            Game.StartGame();
            Console.ReadKey();
        }
    public static class Game
        {
            //charcter name
            static string characterName = "";

            //print out game title
            public static void StartGame()
            {
                Console.WriteLine("********************************************************************************************************************************************* \n");
                Console.WriteLine(@"
 

      __  __           _   _           _ _   __  __             _           _ _               _                 _                  _ 
     |  \/  |         | | (_)         | | | |  \/  |           (_)         | | |     /\      | |               | |                | |
     | \  / |_   _ ___| |_ _  ___ __ _| | | | \  / | __ _  __ _ _  ___ __ _| | |    /  \   __| |_   _____ _ __ | |_ _   _ _ __ ___| |
     | |\/| | | | / __| __| |/ __/ _` | | | | |\/| |/ _` |/ _` | |/ __/ _` | | |   / /\ \ / _` \ \ / / _ \ '_ \| __| | | | '__/ _ \ |
     | |  | | |_| \__ \ |_| | (_| (_| | |_| | |  | | (_| | (_| | | (_| (_| | |_|  / ____ \ (_| |\ V /  __/ | | | |_| |_| | | |  __/_|
     |_|  |_|\__, |___/\__|_|\___\__,_|_(_) |_|  |_|\__,_|\__, |_|\___\__,_|_(_) /_/    \_\__,_| \_/ \___|_| |_|\__|\__,_|_|  \___(_)
              __/ |                                        __/ |                                                                     
             |___/                                        |___/                                                                      
");
                Console.WriteLine(@"      
                                      _____         _____     ____  _   _ ______    _____ _           _   
                                     |  __ \  ___  |  __ \   / __ \| \ | |  ____|  / ____| |         | |  
                                     | |  | |( _ ) | |  | | | |  | |  \| | |__    | (___ | |__   ___ | |_ 
                                     | |  | |/ _ \/\ |  | | | |  | | . ` |  __|    \___ \| '_ \ / _ \| __|
                                     | |__| | (_>  < |__| | | |__| | |\  | |____   ____) | | | | (_) | |_ 
                                     |_____/ \___/\/_____/   \____/|_| \_|______| |_____/|_| |_|\___/ \__|
                                                                      
                                                                      
");
   
               
                Console.WriteLine(@"  
                                    .                  .-.    .  _   *     _   .
                                               *          /   \     ((       _/ \       *    .
                                             _    .   .--'\/\_ \     `      /    \  *    ___
                                         *  / \_    _/ ^      \/\'__        /\/\  /\  __/   \ *
                                           /    \  /    .'   _/  /  \  *' /    \/  \/ .`'\_/\   .
                                      .   /\/\  /\/ :' __  ^/  ^/    `--./.'  ^  `-.\ _    _:\ _
                                         /    \/  \  _/  \-' __/.' ^ _   \_   .'\   _/ \ .  __/ \
                                       /\  .-   `. \/     \ / -.   _/ \ -. `_/   \ /    `._/  ^  \
                                      /  `-.__ ^   / .-'.--'    . /    `--./ .-'  `-.  `-. `.  -  `.
                                    @/        `.  / /      `-.   /  .-'   / .   .'   \    \  \  .-  \%
                                    @&8jgs@@%% @)&@&(88&@.-_=_-=_-=_-=_-=_.8@% &@&&8(8%@%8)(8@%8 8%@)%
                                    @88:::&(&8&&8:::::%&`.~-_~~-~~_~-~_~-~~=.'@(&%::::%@8&8)::&#@8::::
                                    `::::::8%@@%:::::@%&8:`.=~~-.~~-.~~=..~'8::::::::&@8:::::&8:::::'
                                     `::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::.'


");
                Console.WriteLine("\n *********************************************************************************************************************************************");
               
                PlayerName();
                CreateCharacter();

            }
            //ask player for a name, and save it
            public static void PlayerName()
            {
                Dialog( "\n Brave Patron of the arts! To What do ye call yeself?", "blue");
                characterName = Console.ReadLine();
                // Console.WriteLine("I bid ye welcome " + characterName + " I wish ye great tidings on your journey ahead...");
                Console.Write("I bid ye welcome "); Dialog(characterName, "magenta"); Console.Write( " I wish ye great tidings on your journey ahead...");
                
                Console.ReadKey();
            }
            public static void Dialog(string message, string color)
            {
                if (color == "red ") { Console.ForegroundColor = ConsoleColor.DarkRed; }
                if(color == "blue") { Console.ForegroundColor = ConsoleColor.DarkBlue; }
                if (color == "green") { Console.ForegroundColor = ConsoleColor.DarkGreen; }
                if (color == "magenta") { Console.ForegroundColor = ConsoleColor.DarkMagenta; }
                Console.Write(message);
                Console.ResetColor();
            }
            public static void CreateCharacter() {
                String Input = "";
                String Human = " Human";
                String Elf = " Elf";
                String Orc = " Orc"; 
                Dialog("\n Choose your Race: \n [1]"+Human + "\n [2]" + Elf +"\n [3]" + Orc +"\n" , "blue");
                Input = Console.ReadLine();
                Dialog(characterName, "magenta"); Console.WriteLine( " You've chosen the Race of the ");
                if (Input == "2") { Items.Elf(); }
            }
        

        }
    class Items {
            public static void CharacterTraits() {
                String Type;
                String Race;
                int HP;
                int Charisma;
                int Deterity;
                int Constitution;
                int intelligence;
                int wisdom;
                int Strength;
                //String Cantrips[];


            }
            public static void Elf() {
                Console.WriteLine(@"     ELF      
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

            }
          
        }
    }
}
