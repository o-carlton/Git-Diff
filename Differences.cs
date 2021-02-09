using System;
using System.Collections.Generic;
using System.IO;

namespace ObjectOrientedAssignment3

{
    public static class Differences
    {
        public static void Difflocator(string path1, string path2)
        {
            var file1Lines = File.ReadAllLines(path1);
            var file2Lines = File.ReadAllLines(path2);
            var removedFull = new List<string>();
            var addedFull = new List<string>();

            //If file1Lines has more lines than file2Lines
            if (file1Lines.Length > file2Lines.Length)
            {
                for (var i = 0; i < file2Lines.Length; i++)
                {
                    Console.WriteLine("Line {0}:", i + 1);
                    if (file2Lines[i] == file1Lines[i])
                    {
                        Highlighter.Yellow("=");
                        Console.WriteLine(file1Lines[i]);
                    }

                    else if (file2Lines[i] != file1Lines[i])
                    {
                        Highlighter.Red("-");
                        var (removed1, added1) = LineDifferences.LineDifflocator(file1Lines[i], file2Lines[i], true);
                        Highlighter.Green("+");
                        var (removed2, added2) = LineDifferences.LineDifflocator(file1Lines[i], file2Lines[i], false);
                        foreach (var s in removed1)
                        {
                            removedFull.Add(s);
                        }

                        foreach (var s in removed2)
                        {
                            removedFull.Add(s);
                        }

                        foreach (var s in added1)
                        {
                            addedFull.Add(s);
                        }

                        foreach (var s in added2)
                        {
                            addedFull.Add(s);
                        }
                    }
                }
                for (var i = file2Lines.Length; i < file1Lines.Length; i++)
                {
                    Console.WriteLine("Line {0}:", i + 1);
                    Highlighter.Red("-");
                    Highlighter.Red(file1Lines[i]);
                    Console.WriteLine("");
                    var file1Split = file1Lines[i].Split();
                    foreach (var s in file1Split)
                    {
                        removedFull.Add(s);
                    }
                }
            }

            //If file2Lines has more lines than file1Lines
            else if (file1Lines.Length < file2Lines.Length)
            {
                for (var i = 0; i < file1Lines.Length; i++)
                {
                    Console.WriteLine("Line {0}:", i + 1);
                    if (file2Lines[i] == file1Lines[i])
                    {
                        Highlighter.Yellow("=");
                        Console.WriteLine(file2Lines[i]);
                    }

                    else if (file2Lines[i] != file1Lines[i])
                    {
                        Highlighter.Red("-");
                        var (removed1, added1) = LineDifferences.LineDifflocator(file1Lines[i], file2Lines[i], true);
                        Highlighter.Green("+");
                        var (removed2, added2) = LineDifferences.LineDifflocator(file1Lines[i], file2Lines[i], false);
                        foreach (var s in removed1)
                        {
                            removedFull.Add(s);
                        }

                        foreach (var s in removed2)
                        {
                            removedFull.Add(s);
                        }

                        foreach (var s in added1)
                        {
                            addedFull.Add(s);
                        }

                        foreach (var s in added2)
                        {
                            addedFull.Add(s);
                        }
                    }
                }

                for (var i = file1Lines.Length; i < file2Lines.Length; i++)
                {
                    Console.WriteLine("Line {0}:", i + 1);
                    Highlighter.Green("+");
                    Highlighter.Green(file2Lines[i]);
                    Console.WriteLine("");
                    var file2Split = file2Lines[i].Split(" ");
                    foreach (var s in file2Split)
                    {
                        addedFull.Add(s);
                    }
                }
            }

            //If same amount of lines in each file
            else
            {
                for (var i = 0; i < file2Lines.Length; i++)
                {
                    Console.WriteLine("Line {0}:", i + 1);

                    if (file2Lines[i] == file1Lines[i])
                    {
                        Highlighter.Yellow("=");
                        Console.WriteLine(file1Lines[i]);
                    }

                    else if (file2Lines[i] != file1Lines[i])
                    {
                        Highlighter.Red("-");
                        var (removed1, added1) = LineDifferences.LineDifflocator(file1Lines[i], file2Lines[i], true);
                        Highlighter.Green("+");
                        var (removed2, added2) = LineDifferences.LineDifflocator(file1Lines[i], file2Lines[i], false);

                        foreach (var s in removed1)
                        {
                            removedFull.Add(s);
                        }

                        foreach (var s in removed2)
                        {
                            removedFull.Add(s);
                        }

                        foreach (var s in added1)
                        {
                            addedFull.Add(s);
                        }

                        foreach (var s in added2)
                        {
                            addedFull.Add(s);
                        }
                    }
                }
            }

            //Creates Log.txt file
            Log.LogTxt(removedFull, addedFull);
        }
    }
}

