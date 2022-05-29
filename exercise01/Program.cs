using System;
using System.Data;

namespace exercise01
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();


            while (true)
            {
                Console.WriteLine("Enter 'start' to start the stopwatch, 'stop' to stop it, or 'quit' to exit");

                var input1 = Console.ReadLine().ToLower();
                if (!string.IsNullOrWhiteSpace(input1) && input1 == "start")
                    stopwatch.Start();

                else if (input1 == "stop")
                    throw new InvalidOperationException("Stopwatch is not running");

                else if (input1 == "quit")
                    break;

                var input2 = Console.ReadLine().ToLower();
                if (!string.IsNullOrWhiteSpace(input2) && input2 == "stop")
                    Console.WriteLine("Duration: {0}", stopwatch.Stop());

                else if (input2 == "start")
                    throw new InvalidOperationException("Stopwatch is already running");

                else if (input2 == "quit")
                    break;
            }
        }
    }
}
