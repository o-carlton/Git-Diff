using System.Collections.Generic;
using System.IO;

namespace ObjectOrientedAssignment3
{
    public static class Log
    {
        public static void LogTxt(List<string> removedFull, List<string> addedFull)
        {
            //Write a log.txt file
            TextWriter createLog = new StreamWriter("Log.txt");
            createLog.WriteLine("Removed:");

            foreach (var word in removedFull)

                createLog.WriteLine(word);

            createLog.WriteLine("Added:");

            foreach (var l in addedFull)
            {
                createLog.WriteLine(l);
            }

            createLog.Close();
        }
    }
}