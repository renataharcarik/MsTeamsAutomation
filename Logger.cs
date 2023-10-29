using System;
using System.IO;

public class Logger
{
    private static string logFileName = "log.txt";

    public static void Log(string message)
    {
        using (StreamWriter writer = new StreamWriter(logFileName, true))
        {
            writer.WriteLine($"{DateTime.Now}: {message}");
        }
    }
}