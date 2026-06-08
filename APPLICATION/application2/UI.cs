using System;

namespace UI
{
    public static class ConsoleHelper
    {
        public static void DrawHeader(string title)
        {
            Console.WriteLine("\n========================================");
            Console.WriteLine(title);
            Console.WriteLine("========================================");
        }

        public static void Pause()
        {
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}