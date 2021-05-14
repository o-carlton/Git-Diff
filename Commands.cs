using System;
using System.Collections.Generic;
using System.IO;

namespace ObjectOrientedAssignment3
{
    //Adding properties to Variables
    class CommandList
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Syntax { get; set; }
    }

    public static class Commands
    {
        //Code for the help command
        public static void Help(string[] cInput)
        {
            //Command List with name, description and syntax
            List<CommandList> commandList = new List<CommandList>()
            {

                new CommandList() { Name = "help", Desc = "Shows command list, or extra detail for a command", Syntax = "help, help <command>"},
                new CommandList() { Name = "diff", Desc = "Compares two text files if they are the same or not and highlights differences", Syntax = "diff FileALocation.txt FileBLocation.txt"},
                new CommandList() { Name = "exit", Desc = "Exits the current process", Syntax = "exit"},
                new CommandList() { Name = "clear", Desc = "Clears the console screen", Syntax = "clear"},
            };

            //If the user only types help
            if (cInput.Length == 1)
            {
                Highlighter.Yellow("Type Help <command> for more info:");
                Console.WriteLine("");

                foreach (var command in commandList)
                {
                    Console.WriteLine("{0}: {1}", command.Name, command.Desc);
                }
            }

            //If the user types help <command> 
            else
            {   //The command after help
                switch (cInput[1])
                {
                    case "diff"://

                        foreach (var command in commandList)
                        {
                            if (command.Name == cInput[1])
                            {
                                Console.WriteLine("{0}: {1}\nSyntax: {2}", command.Name, command.Desc, command.Syntax);
                            }
                        }
                        break;

                    case "exit":
                        foreach (var command in commandList)
                        {
                            if (command.Name == cInput[1])
                            {
                                Console.WriteLine("{0}: {1}\nSyntax: {2}", command.Name, command.Desc, command.Syntax);
                            }
                        }
                        break;

                    case "help":
                        foreach (var command in commandList)
                        {
                            if (command.Name == cInput[1])
                            {
                                Console.WriteLine("{0}: {1}\nSyntax: {2}", command.Name, command.Desc, command.Syntax);
                            }
                        }
                        break;

                    case "clear":
                        foreach (var command in commandList)
                        {
                            if (command.Name == cInput[1])
                            {
                                Console.WriteLine("{0}: {1}\nSyntax: {2}", command.Name, command.Desc, command.Syntax);
                            }
                        }
                        break;
                    //If no command is recognised
                    default:
                        Highlighter.Red("Command not found: ");
                        Console.WriteLine(cInput[1]);
                        break;
                }
            }
        }

        //Code for testing if files are the same or not
        public static void Diff(string[] cInput)
        {
            //Length of array needs to be 3, error handling
            if (cInput.Length == 3)
            {
                if (File.Exists(cInput[1]) && File.Exists(cInput[2]))
                {
                    //This this short piece of code was modified from:
                    //https://www.dotnetperls.com/file-equals
                    //2007-2020 Sam Allen

                    byte[] file1 = File.ReadAllBytes(cInput[1]);
                    byte[] file2 = File.ReadAllBytes(cInput[2]);

                    if (file1.Length == file2.Length)
                    {
                        for (int i = 0; i < file1.Length; i++)
                        {
                            if (file1[i] != file2[i])
                            {
                                Console.Write("The files are ");
                                Highlighter.Red("not ");
                                Console.WriteLine("the same");
                                Differences.Difflocator(cInput[1], cInput[2]);
                                return;
                            }
                        }
                        Console.Write("The files are the ");
                        Highlighter.Green("same");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.Write("The files are ");
                        Highlighter.Red("not");
                        Console.WriteLine("the same");
                        Differences.Difflocator(cInput[1], cInput[2]);
                    }


                }

                else
                {
                    Console.WriteLine("One or both files dont exist at that directory.");
                }
            }

            //If array isnt correct length, returns error to user
            else
            {
                Console.WriteLine("Incorrect format. Review help command.");
            }
        }

        //Exit function
        public static void Exit()
        {
            Environment.Exit(0);
        }

        //Console clear function
        public static void Clear()
        {
            Console.Clear();
        }

    }
}
