using System;

namespace Turtles
{
    public static class Program
    {
        public static void Main()
        {
            // TODO: Prints "I like turtles." 1000 times.
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine((i + 1) + " I like turtles.");
            }
            Console.ReadLine();
        }
    }
}
