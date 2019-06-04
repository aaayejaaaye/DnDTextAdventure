using System;

namespace AdventureGame
{
    class Program
    {
        static void Main()
        {
            string characterName = "";
            Console.WriteLine("D&D One Shot!");
            Console.WriteLine("A Magical! Mystical! Adventure!");
            Console.WriteLine("By AaayeJaaaye");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Brave Patron of the arts to what do you call yeself?");
            characterName = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("I bid you welcome " + characterName + "I wish ye great tidings on your journey ahead...");
            Console.ReadKey();
        }
    }
}
