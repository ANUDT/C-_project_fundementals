// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {   Console.Title = "Sharpy Hilly Billy";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WindowHeight = 40;

            Console.WriteLine("Hello what is up?");
            Console.ReadLine();

            Console.WriteLine("My name is Sharp the Shark, I am an AI figure and will look after you today?\nWhat can you do?");
            Console.WriteLine("I can sing a song for you");
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}

