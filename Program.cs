using System;

namespace Earth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

	    Console.Write("What is your name:");

	    var name = Console.ReadLine().ToString();

	    Console.WriteLine($"Hello {name}");
        }
    }
}
