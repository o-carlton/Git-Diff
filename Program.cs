using System;
using Microsoft.VisualBasic;

namespace ObjectOrientedAssignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Highlighter.Green("Type help for commands:");
            Console.WriteLine("");

            //Loop to emulate a command prompt-style interface
            while (true)
            {
                Highlighter.Cyan(">");
                var cInput = Strings.Trim(Console.ReadLine()).ToLower().Split();
                //Different commands allowed. If not on the list, will return an error and loop.
                switch (cInput[0])
                {
                    case "":
                        continue;

                    case "help":
                        Commands.Help(cInput);
                        break;

                    case "diff":
                        Commands.Diff(cInput);
                        break;

                    case "exit":
                        Commands.Exit();
                        break;

                    case "clear":
                        Commands.Clear();
                        break;

                    default:
                        Highlighter.Red("Command not found: ");
                        Console.WriteLine(cInput[0]);
                        break;
                }

            }
        }
    }
}