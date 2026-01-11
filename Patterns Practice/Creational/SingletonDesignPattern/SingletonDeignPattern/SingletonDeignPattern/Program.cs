using System;
using System.IO;

public sealed class ErrorLogger
{
    //Private static instance
    private static readonly Lazy<ErrorLogger> _instance = new Lazy<ErrorLogger>(() => new ErrorLogger());
    private readonly string _logfilepath;

    //Private parameterless constructor
    private ErrorLogger()
    {
        _logfilepath = "errorlog.txt";
    }
    
    //pubilc instance prop
    public static ErrorLogger instance
    {
        get { return _instance.Value; }
    }

    //Error Method
    public void LogError(string msg, Exception ex = null)
    {
        string logmsg = $"[{DateTime.Now}] Error: {msg}";
        if (ex != null)
        {
            logmsg += Environment.NewLine + ex;
        }
        File.AppendAllText(_logfilepath, logmsg + Environment.NewLine);
        Console.WriteLine(logmsg);
    }
}
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Started:");
            int value = Divide(10, 0);
        }
        catch (Exception ex) 
        {
            ErrorLogger.instance.LogError("An error rendered", ex);
        }
        Console.WriteLine("ended");
        Console.ReadLine();
    }

    static int Divide(int a, int b)
    {
        return a / b;
    }
}

