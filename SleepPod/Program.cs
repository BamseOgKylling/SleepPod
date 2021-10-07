using System;
using System.Collections.Generic;
using static System.Console;
namespace SleepPod
{
    class Program
    {

        static Dictionary<string, Pod> podDictionary = new Dictionary<string, Pod>();
        static void Main(string[] args)
        {
            // 1.add pod
            // 2.exit


            bool applicationRunning = true;

            do
            {
                WriteLine("1. Add Pod");
                WriteLine("2. Exit");

                CursorVisible = false;

                ConsoleKeyInfo input;
                bool invalidChoice;

                do
                {
                    input = ReadKey(true);

                    invalidChoice = !(input.Key == ConsoleKey.D1 || input.Key == ConsoleKey.NumPad1
                        || input.Key == ConsoleKey.D2 || input.Key == ConsoleKey.NumPad2);

                } while (invalidChoice);

                Clear();

                CursorVisible = true;

                switch (input.Key)
                {
                    case ConsoleKey.D1:

                        AddPod();

                        break;

                    case ConsoleKey.D2:

                        applicationRunning = false;

                        break;
                }

                Clear();

            } while (applicationRunning);
        }

        private static void AddPod()
        {

            Write("Pod ID: ");

            string podId = ReadLine();


            Write("Has TV (Y)es (N)o: ");

            // TODO: Y and N should be the only accepted keys.
            bool hasTV = ReadKey().Key == ConsoleKey.Y ? true : false;

            Pod pod = new Pod(podId, hasTV);

            podDictionary.Add(podId, pod);

        }
    }
}
