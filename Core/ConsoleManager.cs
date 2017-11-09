namespace ListProcessing
{
    using System;
    using System.Collections.Generic;

    public static class ConsoleManager
    {
        public static string Read()
        {
            return Console.ReadLine();
        }

        public static void Write(string message)
        {
            Console.Write(message);
        }

        public static void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
