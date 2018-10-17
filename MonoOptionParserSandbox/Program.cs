using Mono.Options;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MonoOptionParserSandbox
{
    // dotnet exec MonoOptionParserSandbox.dll

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int repetitions = 1;
            List<string> listOfStuff = null;

            var commandLineOptions = new OptionSet
            {
                // A simple parameter to execute a routine
                { "h|?|help", v => ShowHelp() },

                // Example of a numeric parameter assigned to a variable
                { "r|repeat:", v => repetitions = Int32.Parse(v) },

                // Example of a comma delimited list parameter assigned to a variable
                { "l|list:", v => listOfStuff = v.AsDelimitedToList() }
            };

            commandLineOptions.Parse(args);

            if(repetitions > 1)
            {
                Console.WriteLine($"Repetitions requested: {repetitions}");
            }

            if(listOfStuff?.Count > 0)
            {
                foreach(var stuff in listOfStuff)
                {
                    Console.WriteLine($"Processing {stuff}");
                }
            }
        }

        private static void Shell()
        {
            bool running = false;

            var shellOptions = new OptionSet
            {
                { "x|exit", o => running = false }
            };

            while (running)
            {
                var input = Console.ReadLine();

            }
        }

        private static void ShutdownApp()
        {
            Console.WriteLine();       
        }

        private static void ShowHelp()
        {
            Console.WriteLine("Help has not been implemented. Sad trombone.");
        }
    }
}
