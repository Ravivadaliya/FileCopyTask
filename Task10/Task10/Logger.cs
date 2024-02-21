using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    public static class Logger
    {
        public static void Writelog(string message)
        {
            string path = @"D:\Work\Task10\Task10_ErrorLog_File.txt";

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine($"{DateTime.Now} : " + message + "\n");
            }
        }
    }
}
