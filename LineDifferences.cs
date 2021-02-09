using System;
using System.Collections;
using System.Collections.Generic;

namespace ObjectOrientedAssignment3
{
    public class LineDifferences
    {
        public static (List<string> list1, List<string> list2) LineDifflocator(string file1Line, string file2Line, bool del)
        {
            var f1Line = file1Line.Split(" ");
            var f2Line = file2Line.Split(" ");
            var added = new List<string>();
            var removed = new List<string>();

            //If file 1 has more words than file 2
            if (f1Line.Length > f2Line.Length)
            {
                for (var i = 0; i < f2Line.Length; i++)
                {
                    if (del == false)
                    {
                        if (f2Line[i] != f1Line[i])
                        {
                            Highlighter.Green(f2Line[i]);
                            ((IList)added).Add(f2Line[i]);
                        }

                        else
                        {
                            Console.Write(f1Line[i] + " ");
                        }
                    }

                    else
                    {
                        if (f2Line[i] != f1Line[i])
                        {
                            Highlighter.Red(f1Line[i]);
                            ((IList)removed).Add(f1Line[i]);

                        }

                        else
                        {
                            Console.Write(f1Line[i] + " ");
                        }
                    }
                }

                if (del)
                {
                    for (var i = f2Line.Length; i < f1Line.Length; i++)
                    {
                        Highlighter.Red(f1Line[i]);
                        ((IList)removed).Add(f1Line[i]);
                    }
                }
                Console.WriteLine("");


            }

            //If file 1 has less words than file 2
            else if (f1Line.Length < f2Line.Length)
            {
                for (var i = 0; i < f1Line.Length; i++)
                {
                    if (del == false)
                    {
                        if (f2Line[i] != f1Line[i])
                        {
                            Highlighter.Green(f2Line[i]);
                            ((IList)added).Add(f2Line[i]);
                        }

                        else
                        {
                            Console.Write(f1Line[i] + " ");
                        }
                    }

                    else
                    {
                        if (f2Line[i] != f1Line[i])
                        {
                            Highlighter.Red(f1Line[i]);
                            ((IList)removed).Add(f1Line[i]);
                        }

                        else
                        {
                            Console.Write(f1Line[i] + " ");
                        }
                    }
                }

                if (del == false)
                {
                    for (var i = f1Line.Length; i < f2Line.Length; i++)
                    {
                        Highlighter.Green(f2Line[i]);
                        ((IList)added).Add(f2Line[i]);
                    }
                }
                Console.WriteLine("");
            }

            //If same amount of words in both lines
            else
            {
                for (var i = 0; i < f2Line.Length; i++)
                {
                    if (del == false)
                    {
                        if (f2Line[i] != f1Line[i])
                        {
                            Highlighter.Green(f2Line[i]);
                            ((IList)added).Add(f2Line[i]);
                        }

                        else
                        {
                            Console.Write(f1Line[i] + " ");
                        }
                    }

                    else
                    {
                        if (f2Line[i] != f1Line[i])
                        {
                            Highlighter.Red(f1Line[i]);
                            ((IList)removed).Add(f1Line[i]);
                        }

                        else
                        {
                            Console.Write(f1Line[i] + " ");
                        }
                    }
                }
                Console.WriteLine("");
            }

            return (removed, added);
        }
    }
}