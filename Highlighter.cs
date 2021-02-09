using System;
namespace ObjectOrientedAssignment3
{
    //This class allows the highlighting of certain text to help readability
    public static class Highlighter
    {
        //Green text
        public static void Green(string name)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(name+" ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        //Yellow text
        public static void Yellow(string name)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(name+" ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        //Red text
        public static void Red(string name)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(name+" ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        //Cyan text
        public static void Cyan(string name)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(name);
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}