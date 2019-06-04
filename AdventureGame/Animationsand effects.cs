using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Animationsand_effects
    {

        public static void TypeWriter(String Text)
        {

            for (int i = 0; i < Text.Length; i++)
            {

                Console.WriteLine(Text[i]);
                System.Threading.Thread.Sleep(50);


            }
        }
        public static void TypeWriter(String Text, string color)
        {

            for (int i = 0; i < Text.Length; i++)
            {

                Dialog(Text[i], color);
                System.Threading.Thread.Sleep(50);


            }
        }
        public static void Dialog(Char message, string color)
        {
            if (color == "red ") { Console.ForegroundColor = ConsoleColor.DarkRed; }
            if (color == "blue") { Console.ForegroundColor = ConsoleColor.DarkBlue; }
            if (color == "green") { Console.ForegroundColor = ConsoleColor.DarkGreen; }
            if (color == "magenta") { Console.ForegroundColor = ConsoleColor.DarkMagenta; }
            Console.Write(message);
            Console.ResetColor();
        }
        public static void Dialog(String message, string color)
        {
            if (color == "red ") { Console.ForegroundColor = ConsoleColor.DarkRed; }
            if (color == "blue") { Console.ForegroundColor = ConsoleColor.DarkBlue; }
            if (color == "green") { Console.ForegroundColor = ConsoleColor.DarkGreen; }
            if (color == "magenta") { Console.ForegroundColor = ConsoleColor.DarkMagenta; }
            Console.Write(message);
            Console.ResetColor();
        }
    }
}
