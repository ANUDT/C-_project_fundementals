// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp
{
    internal class Program
    {
        //Main method, place to put the code inside "entry method", code will start here
        static void Main(string[] args)
        {

            //class is a container with a bunch of things inside console. will bring options 
            //with a Wrench = variable or property with this we can change our console (color, size or title)
            //box = are for method or function these are comments to ask the console to do different things maybe to write a line of text or user to type something in
            Console.Title = "Sharpy";

            Console.WriteLine("Hello World!");
            //waiting for any type of input from your keyboard and will then close when pressing any key] 
            Console.ReadKey();
        }
    }
}

