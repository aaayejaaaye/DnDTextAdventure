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
                Console.WriteLine("*****************************************************************************************************************");
                Console.WriteLine("D&D One Shot!");
                Console.WriteLine("Magical! Mystical! Adventure!");
                Console.WriteLine("By AaayeJaaaye");
                Console.WriteLine("*****************************************************************************************************************");
                PlayerName();
            }
            //ask player for a name, and save it
            public static void PlayerName()
            {
                Console.WriteLine("Brave Patron of the arts to what do you call yeself?");
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

        }
    class Items {

          
        }
    }
}
