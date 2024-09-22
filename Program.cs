// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //changed console appearance
            Console.Title = "Sharpy Hilly Billy";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WindowHeight = 40;

            //get a conversation going
            Console.WriteLine("Hello what is up?");
            Console.ReadLine();
            Console.WriteLine("My name is Sharp the Shark, I am an AI figure and will look after you today?\nWhat can you do?");
            Console.ReadLine();
            Console.WriteLine("I can sing a song for you");
            Console.ReadLine();
            Console.WriteLine("Shall I sing, I am singing in the rain");
            Console.ReadLine();  
            Console.WriteLine("Ok lets leave that then today :-) ");          
            Console.ReadLine();

            //printing the conversation in console
            Console.ReadKey();
        }
    }
}

