using System;
namespace ControlApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = { "Hello", "2", "world", ":-)" };
            Console.WriteLine(inputArray);

            string[] outputArray = inputArray.Where(s => s.Length <= 3).ToArray();

            Console.WriteLine();

            foreach (string s in outputArray)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
    }

