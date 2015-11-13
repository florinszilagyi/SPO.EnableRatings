using System;

namespace SPO.EnableRatings
{
    public class ConsoleLogger : ILogger
    {
        public void WriteInfo(string msg)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(msg);
            Console.ResetColor();
            Console.WriteLine();
        }

        public void WriteSuccess(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(msg);
            Console.ResetColor();
            Console.WriteLine();
        }

        public void WriteException(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ResetColor();
            Console.WriteLine();
        }

        public void WriteWarning(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(msg);
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}